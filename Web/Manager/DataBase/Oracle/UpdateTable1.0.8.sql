--增加应用排序字段
alter table SYS_APPLICATIONS add A_ORDER NUMBER(10,0);

update SYS_APPLICATIONS set A_ORDER  = 0;
