$(function(){
        $(".table_check_wrap .no").click(function(){
            $(this).parents(".table_check_wrap").find(".yes").attr("checked",false);
            $(this).parents(".table_check_wrap").find(".text_input").val("");
        });

        $(".table_check_wrap .yes").click(function(){
            $(this).parents(".table_check_wrap").find(".no").attr("checked",false);
        });

        $(".gendisease .no").click(function(){
            $(this).parents(".gendisease").find(".yes").attr("checked",false);
            $(this).parents(".gendisease").find(".text_input").val("");
        });

        $(".gendisease .yes").click(function(){
            $(this).parents(".gendisease").find(".no").attr("checked",false);
        });

       $(".table_check_wrap .yes").click(function(){
            /*var parent_w90 = $(this).parents(".w90");
            var data = "[";
            $(parent_w90).find(".yes").each(function(index){
                if($(this).is(":checked")){
                    var ul50 = $(this).parents(".ul50");
                    var date_val = $(ul50).find(".text_input").val();
                    date_val = date_val.replace(/\b(\w)\b/g, '0$1');
                    var dateObj = new Date(date_val.toString());
                    data = data + "{'type':" + $(this).val() +",'date':" + dateObj.getTime() + "},";
                }
            });
            if(data.indexOf(",") > -1)
                data = data.substr(0,data.length - 1);
            data = data + "]";
            $(parent_w90).find(".data").val(data);*/
            if(!$(this).is(":checked")){
                var ul50 = $(this).parents(".ul50");
                $(ul50).find(".text_input").val("");
            }
        });

        $(".family .yes").click(function(){
            var parent_w90 = $(this).parents(".w90");
            var data = "[";
            $(parent_w90).find(".yes").each(function(){
                if($(this).is(":checked")){
                    data = data + "{'type':" + $(this).val() +"},";
                }
            });
            if(data.indexOf(",") > -1)
                data = data.substr(0,data.length - 1);
            data = data + "]";
            $(parent_w90).find(".data").val(data);
        });

        $(".other").click(function(){
                if(!$(this).is(":checked")){
                    $(this).siblings(".text_input").val("");
                }
            });

        //疾病史
        var DiseaseHistory_data = $(".DiseaseHistory_data").val();
        var DiseaseHistory_data_jsonobject = eval("("+DiseaseHistory_data+")"); //转换为json对象
        $(DiseaseHistory_data_jsonobject).each(function( index ){
            var data = DiseaseHistory_data_jsonobject[index];
            $("#DH_Type_"+data.type).attr("checked",true);
            $("#DH_DiagnosisDate_"+data.type).val(toDate(data.date));
        });
        
        //家族史
        //父亲
        var fatherDisease_data = $(".fatherDisease_data").val();
        var fatherDisease_data_jsonobject = eval("("+fatherDisease_data+")"); //转换为json对象
        $(fatherDisease_data_jsonobject).each(function( index ){
            var data = fatherDisease_data_jsonobject[index];
            $("#father_FH_Type_"+data.type).attr("checked",true);
        });

         //母亲
        var matherDisease_data = $(".matherDisease_data").val();
        var matherDisease_data_jsonobject = eval("("+matherDisease_data+")"); //转换为json对象
        $(matherDisease_data_jsonobject).each(function( index ){
            var data = matherDisease_data_jsonobject[index];
            $("#mather_FH_Type_"+data.type).attr("checked",true);
        });

         //兄弟姐妹
        var brothersDisease_data = $(".brothersDisease_data").val();
        var brothersDisease_data_jsonobject = eval("("+brothersDisease_data+")"); //转换为json对象
        $(brothersDisease_data_jsonobject).each(function( index ){
            var data = brothersDisease_data_jsonobject[index];
            $("#brothers_FH_Type_"+data.type).attr("checked",true);
        });

         //子女
        var childrenDisease_data = $(".childrenDisease_data").val();
        var childrenDisease_data_jsonobject = eval("("+childrenDisease_data+")"); //转换为json对象
        $(childrenDisease_data_jsonobject).each(function( index ){
            var data = childrenDisease_data_jsonobject[index];
            $("#children_FH_Type_"+data.type).attr("checked",true);
        });

        //手术史
        jQuery.ajax({
            type: 'POST',
            url: '../../Ajax/DiseaseOther.ashx',
            data: {Op:'paging', Page: 1, DO_Type: 1, DO_UserID: 7},
            success: function (data) {
                if (data) {
                     $("#DO_Type_list1 .list_body").append(data);
                }
            },
            dataType: 'html'
        });

        $(".page1").paginate({
            count: $("#DO_Type_list1 .list_body").find("#page1_info").attr("page-count"),
            start: 1,
            display: 8,
            border_color: '#BEF8B8',
            text_color: '#68BA64',
            background_color: '#E3F2E1',
            border_hover_color: '#68BA64',
            text_hover_color: 'black',
            background_hover_color: '#CAE6C6',
            rotate: false,
            images: false,
            mouse: 'press',
            onChange: function (page) {
                jQuery.ajax({
                    type: 'POST',
                    url: '../../Ajax/DiseaseOther.ashx',
                    data: {Op:'paging', Page: page},
                    success: function (data) {
                        if (data) {
                            if (data) {
                                    $("#DO_Type_list1 .list_body").append(data);
                            }
                        }
                    },
                    dataType: 'html'
                });
            }
        });

        $('.delete').live('click',function () {
            var _this=this;
            var did = $(this).parent().siblings('.first').html();
            jQuery.ajax({
                type: 'POST',
                url: '../ajax/doctor.ashx',
                data: {Op:'delete',Did:did},
                success: function (data) {
                    if (data) {
                        var jsonData = eval("(" + data + ")"); //转换为json对象
                        if(jsonData['success']){
                            TipsWindow('#layer', {}, jsonData['success'], 1500);
                            $(_this).parent().parent().remove();
                        }
                        else
                            TipsWindow('#layer', { 'color': 'red' }, jsonData['fail'], 1500);
                    }
                },
            });
        });
    });