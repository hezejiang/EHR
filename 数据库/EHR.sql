/****** Object:  StoredProcedure [dbo].[sys_ApplicationsInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ApplicationsInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_ApplicationsInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_EventInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_EventInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_EventInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_FieldInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_FieldInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_FieldInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_FieldValueInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_FieldValueInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_FieldValueInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_GroupInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_GroupInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_GroupInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_ModuleExtPermissionInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ModuleExtPermissionInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_ModuleExtPermissionInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_ModuleInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ModuleInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_ModuleInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_OnlineInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_OnlineInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_OnlineInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_RoleApplicationInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RoleApplicationInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_RoleApplicationInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_RolePermissionInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RolePermissionInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_RolePermissionInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_RolesInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RolesInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_RolesInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_SystemInfoInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_SystemInfoInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_SystemInfoInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_UserInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_UserInsertUpdateDelete]
GO
/****** Object:  StoredProcedure [dbo].[sys_UserRolesInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserRolesInsertUpdateDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sys_UserRolesInsertUpdateDelete]
GO
/****** Object:  Table [dbo].[sys_UserRoles]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserRoles]') AND type in (N'U'))
DROP TABLE [dbo].[sys_UserRoles]
GO
/****** Object:  Table [dbo].[sys_User]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_User]') AND type in (N'U'))
DROP TABLE [dbo].[sys_User]
GO
/****** Object:  Table [dbo].[sys_SystemInfo]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_SystemInfo]') AND type in (N'U'))
DROP TABLE [dbo].[sys_SystemInfo]
GO
/****** Object:  Table [dbo].[sys_Roles]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Roles]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Roles]
GO
/****** Object:  Table [dbo].[sys_RolePermission]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]') AND type in (N'U'))
DROP TABLE [dbo].[sys_RolePermission]
GO
/****** Object:  Table [dbo].[sys_RoleApplication]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RoleApplication]') AND type in (N'U'))
DROP TABLE [dbo].[sys_RoleApplication]
GO
/****** Object:  Table [dbo].[sys_Online]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Online]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Online]
GO
/****** Object:  Table [dbo].[sys_Module]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Module]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Module]
GO
/****** Object:  Table [dbo].[sys_ModuleExtPermission]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ModuleExtPermission]') AND type in (N'U'))
DROP TABLE [dbo].[sys_ModuleExtPermission]
GO
/****** Object:  Table [dbo].[sys_Group]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Group]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Group]
GO
/****** Object:  Table [dbo].[sys_FieldValue]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_FieldValue]') AND type in (N'U'))
DROP TABLE [dbo].[sys_FieldValue]
GO
/****** Object:  Table [dbo].[sys_Field]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Field]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Field]
GO
/****** Object:  Table [dbo].[sys_Event]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Event]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Event]
GO
/****** Object:  Table [dbo].[AR_Announcement]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AR_Announcement]') AND type in (N'U'))
DROP TABLE [dbo].[AR_Announcement]
GO
/****** Object:  Table [dbo].[AR_Report]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AR_Report]') AND type in (N'U'))
DROP TABLE [dbo].[AR_Report]
GO
/****** Object:  Table [dbo].[commonDiseases]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[commonDiseases]') AND type in (N'U'))
DROP TABLE [dbo].[commonDiseases]
GO
/****** Object:  Table [dbo].[education_Activity]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[education_Activity]') AND type in (N'U'))
DROP TABLE [dbo].[education_Activity]
GO
/****** Object:  Table [dbo].[education_Document]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[education_Document]') AND type in (N'U'))
DROP TABLE [dbo].[education_Document]
GO
/****** Object:  Table [dbo].[education_Prescription]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[education_Prescription]') AND type in (N'U'))
DROP TABLE [dbo].[education_Prescription]
GO
/****** Object:  Table [dbo].[extend_Disability]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_Disability]') AND type in (N'U'))
DROP TABLE [dbo].[extend_Disability]
GO
/****** Object:  Table [dbo].[extend_DiseaseHistory]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_DiseaseHistory]') AND type in (N'U'))
DROP TABLE [dbo].[extend_DiseaseHistory]
GO
/****** Object:  Table [dbo].[extend_DiseaseOther]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_DiseaseOther]') AND type in (N'U'))
DROP TABLE [dbo].[extend_DiseaseOther]
GO
/****** Object:  Table [dbo].[extend_Environment]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_Environment]') AND type in (N'U'))
DROP TABLE [dbo].[extend_Environment]
GO
/****** Object:  Table [dbo].[extend_FamilyHistory]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_FamilyHistory]') AND type in (N'U'))
DROP TABLE [dbo].[extend_FamilyHistory]
GO
/****** Object:  Table [dbo].[extend_GeneticDisease]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_GeneticDisease]') AND type in (N'U'))
DROP TABLE [dbo].[extend_GeneticDisease]
GO
/****** Object:  Table [dbo].[Nation]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nation]') AND type in (N'U'))
DROP TABLE [dbo].[Nation]
GO
/****** Object:  Table [dbo].[record_Consultation]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_Consultation]') AND type in (N'U'))
DROP TABLE [dbo].[record_Consultation]
GO
/****** Object:  Table [dbo].[record_DeathRegistration]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_DeathRegistration]') AND type in (N'U'))
DROP TABLE [dbo].[record_DeathRegistration]
GO
/****** Object:  Table [dbo].[record_FamilyBaseInfo]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]') AND type in (N'U'))
DROP TABLE [dbo].[record_FamilyBaseInfo]
GO
/****** Object:  Table [dbo].[record_FimaryProblem]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_FimaryProblem]') AND type in (N'U'))
DROP TABLE [dbo].[record_FimaryProblem]
GO
/****** Object:  Table [dbo].[record_FollowUp]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_FollowUp]') AND type in (N'U'))
DROP TABLE [dbo].[record_FollowUp]
GO
/****** Object:  Table [dbo].[record_HealthCheck]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]') AND type in (N'U'))
DROP TABLE [dbo].[record_HealthCheck]
GO
/****** Object:  Table [dbo].[record_Medication]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_Medication]') AND type in (N'U'))
DROP TABLE [dbo].[record_Medication]
GO
/****** Object:  Table [dbo].[record_MedicationTime]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_MedicationTime]') AND type in (N'U'))
DROP TABLE [dbo].[record_MedicationTime]
GO
/****** Object:  Table [dbo].[record_UserBaseInfo]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]') AND type in (N'U'))
DROP TABLE [dbo].[record_UserBaseInfo]
GO
/****** Object:  Table [dbo].[supervision_Info]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[supervision_Info]') AND type in (N'U'))
DROP TABLE [dbo].[supervision_Info]
GO
/****** Object:  Table [dbo].[supervision_Inspect]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[supervision_Inspect]') AND type in (N'U'))
DROP TABLE [dbo].[supervision_Inspect]
GO
/****** Object:  StoredProcedure [dbo].[SupesoftPage]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupesoftPage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SupesoftPage]
GO
/****** Object:  Table [dbo].[sys_Applications]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Applications]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Applications]
GO
/****** Object:  Default [DF_AR_Announcement_A_Title]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AR_Announcement_A_Title]') AND parent_object_id = OBJECT_ID(N'[dbo].[AR_Announcement]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AR_Announcement_A_Title]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AR_Announcement] DROP CONSTRAINT [DF_AR_Announcement_A_Title]
END


End
GO
/****** Object:  Default [DF_AR_Announcement_A_Detail]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AR_Announcement_A_Detail]') AND parent_object_id = OBJECT_ID(N'[dbo].[AR_Announcement]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AR_Announcement_A_Detail]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AR_Announcement] DROP CONSTRAINT [DF_AR_Announcement_A_Detail]
END


End
GO
/****** Object:  Default [DF_AR_Report_R_Detail]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AR_Report_R_Detail]') AND parent_object_id = OBJECT_ID(N'[dbo].[AR_Report]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AR_Report_R_Detail]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AR_Report] DROP CONSTRAINT [DF_AR_Report_R_Detail]
END


End
GO
/****** Object:  Default [DF_education_Activity_A_Duration]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Activity_A_Duration]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Activity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Activity_A_Duration]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Activity] DROP CONSTRAINT [DF_education_Activity_A_Duration]
END


End
GO
/****** Object:  Default [DF_education_Activity_A_Partners]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Activity_A_Partners]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Activity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Activity_A_Partners]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Activity] DROP CONSTRAINT [DF_education_Activity_A_Partners]
END


End
GO
/****** Object:  Default [DF_education_Activity_A_Missionary]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Activity_A_Missionary]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Activity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Activity_A_Missionary]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Activity] DROP CONSTRAINT [DF_education_Activity_A_Missionary]
END


End
GO
/****** Object:  Default [DF_education_Activity_A_Number]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Activity_A_Number]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Activity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Activity_A_Number]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Activity] DROP CONSTRAINT [DF_education_Activity_A_Number]
END


End
GO
/****** Object:  Default [DF_education_Prescription_P_Content]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Prescription_P_Content]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Prescription]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Prescription_P_Content]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Prescription] DROP CONSTRAINT [DF_education_Prescription_P_Content]
END


End
GO
/****** Object:  Default [DF_extend_Disability_D_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_extend_Disability_D_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[extend_Disability]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_extend_Disability_D_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[extend_Disability] DROP CONSTRAINT [DF_extend_Disability_D_Note]
END


End
GO
/****** Object:  Default [DF_extend_DiseaseHistory_D_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_extend_DiseaseHistory_D_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[extend_DiseaseHistory]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_extend_DiseaseHistory_D_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[extend_DiseaseHistory] DROP CONSTRAINT [DF_extend_DiseaseHistory_D_Note]
END


End
GO
/****** Object:  Default [DF_extend_FamilyHistory_DH_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_extend_FamilyHistory_DH_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[extend_FamilyHistory]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_extend_FamilyHistory_DH_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[extend_FamilyHistory] DROP CONSTRAINT [DF_extend_FamilyHistory_DH_Note]
END


End
GO
/****** Object:  Default [DF_record_Consultation_C_Cause]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Consultation_C_Cause]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_Consultation]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Consultation_C_Cause]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_Consultation] DROP CONSTRAINT [DF_record_Consultation_C_Cause]
END


End
GO
/****** Object:  Default [DF_record_Consultation_C_Comments]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Consultation_C_Comments]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_Consultation]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Consultation_C_Comments]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_Consultation] DROP CONSTRAINT [DF_record_Consultation_C_Comments]
END


End
GO
/****** Object:  Default [DF_record_DeathRegistration_D_Icd10ID]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_DeathRegistration_D_Icd10ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_DeathRegistration]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_DeathRegistration_D_Icd10ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_DeathRegistration] DROP CONSTRAINT [DF_record_DeathRegistration_D_Icd10ID]
END


End
GO
/****** Object:  Default [DF_record_DeathRegistration_D_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_DeathRegistration_D_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_DeathRegistration]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_DeathRegistration_D_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_DeathRegistration] DROP CONSTRAINT [DF_record_DeathRegistration_D_Note]
END


End
GO
/****** Object:  Default [DF_record_DeathRegistration_D_UserID]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_DeathRegistration_D_UserID]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_DeathRegistration]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_DeathRegistration_D_UserID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_DeathRegistration] DROP CONSTRAINT [DF_record_DeathRegistration_D_UserID]
END


End
GO
/****** Object:  Default [DF_record_Family_F_FimaryTel]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_FimaryTel]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_FimaryTel]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_FimaryTel]
END


End
GO
/****** Object:  Default [DF_record_Family_F_FimrayAddress]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_FimrayAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_FimrayAddress]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_FimrayAddress]
END


End
GO
/****** Object:  Default [DF_record_Family_F_HouseType]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_HouseType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_HouseType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_HouseType]
END


End
GO
/****** Object:  Default [DF_record_Family_F_HouseArea]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_HouseArea]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_HouseArea]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_HouseArea]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Ventilation]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Ventilation]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Ventilation]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_Ventilation]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Humidity]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Humidity]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Humidity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_Humidity]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Warm]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Warm]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Warm]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_Warm]
END


End
GO
/****** Object:  Default [DF_record_Family_Lighting]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_Lighting]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_Lighting]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_Lighting]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Sanitation]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Sanitation]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Sanitation]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_Sanitation]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Kitchen]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Kitchen]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Kitchen]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_Kitchen]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Fuel]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Fuel]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Fuel]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_Fuel]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Water]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Water]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Water]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_Water]
END


End
GO
/****** Object:  Default [DF_record_Family_F_WasteDisposal]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_WasteDisposal]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_WasteDisposal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_WasteDisposal]
END


End
GO
/****** Object:  Default [DF_record_Family_F_LivestockBar]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_LivestockBar]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_LivestockBar]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_LivestockBar]
END


End
GO
/****** Object:  Default [DF_record_Family_F_ToiletType]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_ToiletType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_ToiletType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] DROP CONSTRAINT [DF_record_Family_F_ToiletType]
END


End
GO
/****** Object:  Default [DF_record_FollowUp_F_PatientID]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_FollowUp_F_PatientID]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FollowUp]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_FollowUp_F_PatientID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FollowUp] DROP CONSTRAINT [DF_record_FollowUp_F_PatientID]
END


End
GO
/****** Object:  Default [DF_record_FollowUp_F_Status]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_FollowUp_F_Status]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FollowUp]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_FollowUp_F_Status]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FollowUp] DROP CONSTRAINT [DF_record_FollowUp_F_Status]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_BodyTemperature]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_BodyTemperature]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_BodyTemperature]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_BodyTemperature]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_PulseRate]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_PulseRate]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_PulseRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_PulseRate]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_RespiratoryRate]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_RespiratoryRate]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_RespiratoryRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_RespiratoryRate]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftDiastolicBloodPressure]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_LeftDiastolicBloodPressure]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_LeftDiastolicBloodPressure]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_LeftDiastolicBloodPressure]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftSystolic]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_LeftSystolic]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_LeftSystolic]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_LeftSystolic]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftDiastolic1]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_LeftDiastolic1]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_LeftDiastolic1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_LeftDiastolic1]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftSystolic1]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_LeftSystolic1]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_LeftSystolic1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_LeftSystolic1]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_Height]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_Height]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_Height]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_Height]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_Weight]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_Weight]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_Weight]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_Weight]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_Result]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_Result]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_Result]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_Result]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_Suggestion]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_Suggestion]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_Suggestion]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] DROP CONSTRAINT [DF_record_HealthCheck_H_Suggestion]
END


End
GO
/****** Object:  Default [DF_record_Medication_MedicationID]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Medication_MedicationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_Medication]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Medication_MedicationID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_Medication] DROP CONSTRAINT [DF_record_Medication_MedicationID]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingUnits]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_WorkingUnits]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_WorkingUnits]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_WorkingUnits]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingContactName]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_WorkingContactName]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_WorkingContactName]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_WorkingContactName]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingContactPhone]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_WorkingContactPhone]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_WorkingContactPhone]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_WorkingContactPhone]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_BloodType]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_BloodType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_BloodType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_BloodType]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_MarriageStatus]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_MarriageStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_MarriageStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_MarriageStatus]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_PermanentType]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_PermanentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_PermanentType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_PermanentType]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_Education]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_Education]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_Education]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_Education]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_PaymentType]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_PaymentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_PaymentType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_PaymentType]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_SocialSecurityNO]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_SocialSecurityNO]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_SocialSecurityNO]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_SocialSecurityNO]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_FamilyNO]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_FamilyNO]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_FamilyNO]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_BaseInfo_B_FamilyNO]
END


End
GO
/****** Object:  Default [DF_record_UserBaseInfo_U_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_UserBaseInfo_U_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_UserBaseInfo_U_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] DROP CONSTRAINT [DF_record_UserBaseInfo_U_Note]
END


End
GO
/****** Object:  Default [DF_supervision_Info_I_Content]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_supervision_Info_I_Content]') AND parent_object_id = OBJECT_ID(N'[dbo].[supervision_Info]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_supervision_Info_I_Content]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[supervision_Info] DROP CONSTRAINT [DF_supervision_Info_I_Content]
END


End
GO
/****** Object:  Default [DF_supervision_Inspect_I_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_supervision_Inspect_I_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[supervision_Inspect]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_supervision_Inspect_I_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[supervision_Inspect] DROP CONSTRAINT [DF_supervision_Inspect_I_Note]
END


End
GO
/****** Object:  Default [DF__sys_Event__E_Dat__7F60ED59]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Event__E_Dat__7F60ED59]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Event]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Event__E_Dat__7F60ED59]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Event] DROP CONSTRAINT [DF__sys_Event__E_Dat__7F60ED59]
END


End
GO
/****** Object:  Default [DF__sys_Event__E_Typ__00551192]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Event__E_Typ__00551192]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Event]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Event__E_Typ__00551192]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Event] DROP CONSTRAINT [DF__sys_Event__E_Typ__00551192]
END


End
GO
/****** Object:  Default [DF__sys_Field__V_Sho__0519C6AF]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Field__V_Sho__0519C6AF]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_FieldValue]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Field__V_Sho__0519C6AF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_FieldValue] DROP CONSTRAINT [DF__sys_Field__V_Sho__0519C6AF]
END


End
GO
/****** Object:  Default [DF__sys_Group__G_Par__07F6335A]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Group__G_Par__07F6335A]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Group]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Group__G_Par__07F6335A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Group] DROP CONSTRAINT [DF__sys_Group__G_Par__07F6335A]
END


End
GO
/****** Object:  Default [DF__sys_Group__G_Sho__08EA5793]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Group__G_Sho__08EA5793]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Group]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Group__G_Sho__08EA5793]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Group] DROP CONSTRAINT [DF__sys_Group__G_Sho__08EA5793]
END


End
GO
/****** Object:  Default [DF_sys_Group_G_Type]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Group_G_Type]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Group]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_sys_Group_G_Type]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Group] DROP CONSTRAINT [DF_sys_Group_G_Type]
END


End
GO
/****** Object:  Default [DF_sys_Group_G_Code]    Script Date: 06/08/2013 10:03:43 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Group_G_Code]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Group]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_sys_Group_G_Code]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Group] DROP CONSTRAINT [DF_sys_Group_G_Code]
END


End
GO
/****** Object:  Default [DF__sys_User__U_Type__1920BF5C]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_User__U_Type__1920BF5C]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_User__U_Type__1920BF5C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] DROP CONSTRAINT [DF__sys_User__U_Type__1920BF5C]
END


End
GO
/****** Object:  Default [DF__sys_User__U_Stat__1A14E395]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_User__U_Stat__1A14E395]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_User__U_Stat__1A14E395]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] DROP CONSTRAINT [DF__sys_User__U_Stat__1A14E395]
END


End
GO
/****** Object:  Default [DF_sys_User_U_HospitalGroupID]    Script Date: 06/08/2013 10:03:44 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_User_U_HospitalGroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_sys_User_U_HospitalGroupID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] DROP CONSTRAINT [DF_sys_User_U_HospitalGroupID]
END


End
GO
/****** Object:  Table [dbo].[sys_Applications]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Applications]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Applications](
	[ApplicationID] [int] IDENTITY(1,1) NOT NULL,
	[A_AppName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[A_AppDescription] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[A_AppUrl] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[A_Order] [int] NULL,
 CONSTRAINT [PK_SYS_APPLICATIONS] PRIMARY KEY NONCLUSTERED 
(
	[ApplicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Applications', N'COLUMN',N'ApplicationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自动ID 1:为系统管理应用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'ApplicationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Applications', N'COLUMN',N'A_AppName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'A_AppName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Applications', N'COLUMN',N'A_AppDescription'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用介绍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'A_AppDescription'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Applications', N'COLUMN',N'A_AppUrl'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用Url地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'A_AppUrl'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Applications', N'COLUMN',N'A_Order'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'A_Order'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Applications', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications'
GO
SET IDENTITY_INSERT [dbo].[sys_Applications] ON
INSERT [dbo].[sys_Applications] ([ApplicationID], [A_AppName], [A_AppDescription], [A_AppUrl], [A_Order]) VALUES (1, N'基础模组', N'基础模组成部分', N'http://framework.web', NULL)
SET IDENTITY_INSERT [dbo].[sys_Applications] OFF
/****** Object:  StoredProcedure [dbo].[SupesoftPage]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupesoftPage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




/*********************************************************************************
*      Copyright (C) 2005 141421.com,All Rights Reserved						 *
*      Function:  SuperPaging													 *
*      Description:                                                              *
*             超强通用分页存储过程												 *
*      Author:                                                                   *
*             邱学军(Ryan)                                                       *
*             lifergb@hotmail.com                                                *
*             http://www.141421.com                                              *
*      Finish DateTime:                                                          *
*             2005年9月24日                                                      *
*      History:																	 *
*             2006/4/21 Edit By Michael Li                                       *         
*	   Example:																	 *
*	          SuperPaging @TableName=''表名'',@Orderfld=''排序列名''                 *           
*********************************************************************************/
CREATE PROCEDURE [dbo].[SupesoftPage]
(
	@TableName		nvarchar(50),			-- 表名
	@ReturnFields	nvarchar(2000) = ''*'',	-- 需要返回的列 
	@PageSize		int = 10,				-- 每页记录数
	@PageIndex		int = 1,				-- 当前页码
	@Where			nvarchar(2000) = '''',		-- 查询条件
	@Orderfld		nvarchar(2000),			-- 排序字段名 最好为唯一主键
	@OrderType		int = 1					-- 排序类型 1:降序 其它为升序
	
)
AS
    DECLARE @TotalRecord int
	DECLARE @TotalPage int
	DECLARE @CurrentPageSize int
    DECLARE @TotalRecordForPageIndex int
    DECLARE @OrderBy nvarchar(255)
    DECLARE @CutOrderBy nvarchar(255)
	
	if @OrderType = 1
		BEGIN
			set @OrderBy = '' Order by '' + REPLACE(@Orderfld,'','','' desc,'') + '' desc ''
			set @CutOrderBy = '' Order by ''+ REPLACE(@Orderfld,'','','' asc,'') + '' asc ''
		END
	else
		BEGIN
			set @OrderBy = '' Order by '' +  REPLACE(@Orderfld,'','','' asc,'') + '' asc ''
			set @CutOrderBy = '' Order by ''+ REPLACE(@Orderfld,'','','' desc,'') + '' desc ''			
		END
	
	
        -- 记录总数
	declare @countSql nvarchar(4000)  
	set @countSql=''SELECT @TotalRecord=Count(*) From ''+@TableName+'' ''+@Where
	execute sp_executesql @countSql,N''@TotalRecord int out'',@TotalRecord out
	
	SET @TotalPage=(@TotalRecord-1)/@PageSize+1
	SET @CurrentPageSize=@PageSize
        IF(@TotalPage=@PageIndex)
	BEGIN
		SET @CurrentPageSize=@TotalRecord%@PageSize
		IF(@CurrentPageSize=0)
			SET @CurrentPageSize=@PageSize
	END
	-- 返回记录
	set @TotalRecordForPageIndex=@PageIndex*@PageSize
	exec(''SELECT * FROM
		(SELECT TOP ''+@CurrentPageSize+'' * FROM
			(SELECT TOP ''+@TotalRecordForPageIndex+'' ''+@ReturnFields+''
			FROM ''+@TableName+'' ''+@Where+'' ''+@OrderBy+'') TB2
		''+@CutOrderBy+'') TB3
              ''+@OrderBy)
	-- 返回总页数和总记录数
	SELECT @TotalPage as PageCount,@TotalRecord as RecordCount




' 
END
GO
/****** Object:  Table [dbo].[supervision_Inspect]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[supervision_Inspect]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[supervision_Inspect](
	[InspectID] [int] IDENTITY(1,1) NOT NULL,
	[I_Location] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[I_Type] [tinyint] NOT NULL,
	[I_Date] [datetime] NOT NULL,
	[I_UserID] [int] NOT NULL,
	[I_Conent] [text] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[I_MainProblem] [text] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[I_Note] [text] COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_supervision_Inspect] PRIMARY KEY CLUSTERED 
(
	[InspectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Inspect', N'COLUMN',N'InspectID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卫生监管巡查ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'InspectID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Inspect', N'COLUMN',N'I_Date'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'巡查时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_Date'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Inspect', N'COLUMN',N'I_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'巡查人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Inspect', N'COLUMN',N'I_Conent'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'寻常内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_Conent'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Inspect', N'COLUMN',N'I_MainProblem'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发现的主要问题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_MainProblem'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Inspect', N'COLUMN',N'I_Note'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_Note'
GO
/****** Object:  Table [dbo].[supervision_Info]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[supervision_Info]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[supervision_Info](
	[InfoID] [int] IDENTITY(1,1) NOT NULL,
	[I_FindDate] [datetime] NOT NULL,
	[I_Type] [tinyint] NOT NULL,
	[I_Content] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[I_ReportDate] [datetime] NOT NULL,
	[I_ReportUserID] [int] NOT NULL,
 CONSTRAINT [PK_supervision_Info] PRIMARY KEY CLUSTERED 
(
	[InfoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Info', N'COLUMN',N'InfoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卫生监督信息ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'InfoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Info', N'COLUMN',N'I_FindDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发现时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_FindDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Info', N'COLUMN',N'I_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'信息类别，1：食品安全，2：饮用水卫生，3：职业病安全，4：学校卫生，5：非法行医（采供血）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Info', N'COLUMN',N'I_Content'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'信息内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_Content'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Info', N'COLUMN',N'I_ReportDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_ReportDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'supervision_Info', N'COLUMN',N'I_ReportUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_ReportUserID'
GO
SET IDENTITY_INSERT [dbo].[supervision_Info] ON
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (2, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试2', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (3, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (4, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (5, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (6, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (7, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (8, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (9, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (10, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (11, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (12, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (13, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (14, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (15, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (16, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (17, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (18, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 2)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (19, CAST(0x0000A1BA00000000 AS DateTime), 3, N'职业病安全测试', CAST(0x0000A1BC00000000 AS DateTime), 3)
INSERT [dbo].[supervision_Info] ([InfoID], [I_FindDate], [I_Type], [I_Content], [I_ReportDate], [I_ReportUserID]) VALUES (20, CAST(0x0000A1BD00000000 AS DateTime), 5, N'feifa', CAST(0x0000A1BE00000000 AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[supervision_Info] OFF
/****** Object:  Table [dbo].[record_UserBaseInfo]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_UserBaseInfo](
	[UserID] [int] NOT NULL,
	[U_Hometown] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[U_CurrentAddress] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[U_FilingUnits] [int] NOT NULL,
	[U_FilingUserID] [int] NOT NULL,
	[U_ResponsibilityUserID] [int] NOT NULL,
	[U_Committee] [int] NOT NULL,
	[U_FlingTime] [datetime] NOT NULL,
	[U_WorkingUnits] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[U_WorkingContactName] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[U_WorkingContactTel] [varchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[U_BloodType] [tinyint] NULL,
	[U_NationID] [tinyint] NULL,
	[U_MarriageStatus] [tinyint] NULL,
	[U_PermanentType] [tinyint] NULL,
	[U_Education] [tinyint] NULL,
	[U_PaymentType] [varchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[U_SocialNO] [varchar](30) COLLATE Chinese_PRC_CI_AS NULL,
	[U_MedicalNO] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[U_FamilyCode] [varchar](22) COLLATE Chinese_PRC_CI_AS NULL,
	[U_RelationShip] [tinyint] NULL,
	[U_AuditStatus] [tinyint] NULL,
	[U_Note] [text] COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_record_BaseInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_Hometown'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'户籍地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_Hometown'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_CurrentAddress'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'现住址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_CurrentAddress'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_FilingUnits'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档单位（居委会或者是医院部门）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_FilingUnits'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_FilingUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档人，与sys_User表中的UerID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_FilingUserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_ResponsibilityUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'责任医生，与sys_User表中的UerID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_ResponsibilityUserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_Committee'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'居(村)委会' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_Committee'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_FlingTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_FlingTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_WorkingUnits'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工作单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_WorkingUnits'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_WorkingContactName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位联系人姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_WorkingContactName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_WorkingContactTel'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位联系人电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_WorkingContactTel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_BloodType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'血型 1:A型，2:B型，3:AB型，4:O型，0:不详' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_BloodType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_NationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'民族，对应民族表NationID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_NationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_MarriageStatus'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'婚姻状态 1:未婚，2:已婚，3:丧偶，4:离婚' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_MarriageStatus'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_PermanentType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'常住类型 1:户籍，2:非户籍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_PermanentType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_Education'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文化程度 0:不详, 1:文盲及半文盲，2:小学，3:中学，4:高中/技校/中专，5:大学专科，6:大学本科，7:研究生及以上' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_Education'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_PaymentType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'付费类型(可多选，以逗号隔开) 1:城镇职工基本医疗保险，2:城镇居民基本医疗保险，3:贫困扶助，4:新型农村合作医疗，5:商业医疗保险，6:全公费，7:全自费，8:其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_PaymentType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_SocialNO'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'社保号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_SocialNO'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_MedicalNO'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医保号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_MedicalNO'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_FamilyCode'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭编号，与家庭健康档案F_FamilyCode相对应' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_FamilyCode'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_RelationShip'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'与户主关系 0:户主 1:父亲 2:母亲 3:儿子 4:儿媳 5:女儿 6:女婿' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_RelationShip'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_AuditStatus'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'档案状态，1：正常，2：审核中（迁出迁入需要审核）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_AuditStatus'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_UserBaseInfo', N'COLUMN',N'U_Note'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_Note'
GO
INSERT [dbo].[record_UserBaseInfo] ([UserID], [U_Hometown], [U_CurrentAddress], [U_FilingUnits], [U_FilingUserID], [U_ResponsibilityUserID], [U_Committee], [U_FlingTime], [U_WorkingUnits], [U_WorkingContactName], [U_WorkingContactTel], [U_BloodType], [U_NationID], [U_MarriageStatus], [U_PermanentType], [U_Education], [U_PaymentType], [U_SocialNO], [U_MedicalNO], [U_FamilyCode], [U_RelationShip], [U_AuditStatus], [U_Note]) VALUES (2, N'广东茂名', N'广东茂名茂港', 1, 1, 1, 5, CAST(0x0000A1BC00000000 AS DateTime), N'', N'', N'', 0, NULL, 0, 0, 0, N'', N'', NULL, N'0', 7, NULL, NULL)
INSERT [dbo].[record_UserBaseInfo] ([UserID], [U_Hometown], [U_CurrentAddress], [U_FilingUnits], [U_FilingUserID], [U_ResponsibilityUserID], [U_Committee], [U_FlingTime], [U_WorkingUnits], [U_WorkingContactName], [U_WorkingContactTel], [U_BloodType], [U_NationID], [U_MarriageStatus], [U_PermanentType], [U_Education], [U_PaymentType], [U_SocialNO], [U_MedicalNO], [U_FamilyCode], [U_RelationShip], [U_AuditStatus], [U_Note]) VALUES (7, N'广东茂名', N'广东深圳', 10, 2, 2, 5, CAST(0x0000A1C0001D6F28 AS DateTime), N'顺科', N'小溪', N'12324', 4, 5, 1, 1, 6, N'2', N'11111', N'22222234', N'0', 0, 1, N'发vsd')
/****** Object:  Table [dbo].[record_MedicationTime]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_MedicationTime]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_MedicationTime](
	[MedicationTimeID] [int] IDENTITY(1,1) NOT NULL,
	[M_Time] [varchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[MedicationID] [int] NOT NULL,
 CONSTRAINT [PK_record_MedicationTime] PRIMARY KEY CLUSTERED 
(
	[MedicationTimeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_MedicationTime', N'COLUMN',N'MedicationTimeID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用药时间ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_MedicationTime', @level2type=N'COLUMN',@level2name=N'MedicationTimeID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_MedicationTime', N'COLUMN',N'M_Time'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'服药时间点（24小时制，如：15:30:00）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_MedicationTime', @level2type=N'COLUMN',@level2name=N'M_Time'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_MedicationTime', N'COLUMN',N'MedicationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'与record_Medication表MedicationID相关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_MedicationTime', @level2type=N'COLUMN',@level2name=N'MedicationID'
GO
SET IDENTITY_INSERT [dbo].[record_MedicationTime] ON
INSERT [dbo].[record_MedicationTime] ([MedicationTimeID], [M_Time], [MedicationID]) VALUES (2, N'12:00:00', 1)
SET IDENTITY_INSERT [dbo].[record_MedicationTime] OFF
/****** Object:  Table [dbo].[record_Medication]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_Medication]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_Medication](
	[MedicationID] [int] NOT NULL,
	[M_ConsultationID] [int] NOT NULL,
	[M_StartDate] [datetime] NOT NULL,
	[M_Status] [tinyint] NULL,
 CONSTRAINT [PK_record_Medication] PRIMARY KEY CLUSTERED 
(
	[MedicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Medication', N'COLUMN',N'MedicationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用药ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Medication', @level2type=N'COLUMN',@level2name=N'MedicationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Medication', N'COLUMN',N'M_ConsultationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊流水号，与record_Consultation表相关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Medication', @level2type=N'COLUMN',@level2name=N'M_ConsultationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Medication', N'COLUMN',N'M_StartDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用药开始日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Medication', @level2type=N'COLUMN',@level2name=N'M_StartDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Medication', N'COLUMN',N'M_Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用药状态，1：正在服用，2：已服用完（病人服用完药之后将该提醒取消并同步就说明服用完毕）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Medication', @level2type=N'COLUMN',@level2name=N'M_Status'
GO
/****** Object:  Table [dbo].[record_HealthCheck]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_HealthCheck](
	[HealthID] [int] IDENTITY(1,1) NOT NULL,
	[H_BodyTemperature] [float] NULL,
	[H_PulseRate] [tinyint] NULL,
	[H_RespiratoryRate] [tinyint] NULL,
	[H_LeftDiastolic] [tinyint] NULL,
	[H_LeftSystolic] [tinyint] NULL,
	[H_RightDiastolic] [tinyint] NULL,
	[H_RightSystolic] [tinyint] NULL,
	[H_Height] [tinyint] NULL,
	[H_Weight] [tinyint] NULL,
	[H_Result] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[H_Suggestion] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[H_CheckTime] [datetime] NOT NULL,
	[H_MedicalInstitutions] [int] NOT NULL,
	[H_CheckUserID] [int] NOT NULL,
	[H_UserID] [int] NOT NULL,
 CONSTRAINT [PK_record_HealthCheck] PRIMARY KEY CLUSTERED 
(
	[HealthID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'HealthID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康体检ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'HealthID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_BodyTemperature'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体温' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_BodyTemperature'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_PulseRate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'脉率（次/min）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_PulseRate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_RespiratoryRate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'呼吸频率（次/min）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_RespiratoryRate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_LeftDiastolic'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'左侧舒张压(mmHg)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_LeftDiastolic'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_LeftSystolic'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'左侧收缩压(mmHg)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_LeftSystolic'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_RightDiastolic'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'右侧舒张压(mmHg)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_RightDiastolic'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_RightSystolic'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'右侧收缩压(mmHg)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_RightSystolic'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_Height'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身高（cm）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_Height'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_Weight'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体重（kg）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_Weight'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_Result'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检结果' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_Result'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_Suggestion'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检建议' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_Suggestion'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_CheckTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_CheckTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_MedicalInstitutions'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检机构，与sys_Group表中的GroupID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_MedicalInstitutions'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_HealthCheck', N'COLUMN',N'H_CheckUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检医生，与sys_User表中的UserID相关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_CheckUserID'
GO
/****** Object:  Table [dbo].[record_FollowUp]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_FollowUp]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_FollowUp](
	[FollowUpID] [int] IDENTITY(1,1) NOT NULL,
	[F_PatientID] [int] NOT NULL,
	[F_Type] [tinyint] NULL,
	[F_Date] [datetime] NULL,
	[F_Status] [tinyint] NULL,
 CONSTRAINT [PK_record_Work] PRIMARY KEY CLUSTERED 
(
	[FollowUpID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FollowUp', N'COLUMN',N'FollowUpID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工作ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'FollowUpID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FollowUp', N'COLUMN',N'F_PatientID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'病人ID，与sys_User中的UserID相关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'F_PatientID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FollowUp', N'COLUMN',N'F_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'随访类型，1：高血压，2：糖尿病患者，3：儿童防疫，4：老年人保健' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'F_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FollowUp', N'COLUMN',N'F_Date'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'下次随访日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'F_Date'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FollowUp', N'COLUMN',N'F_Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'随访状态 1：未完成，2：已完成，3：已到期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'F_Status'
GO
SET IDENTITY_INSERT [dbo].[record_FollowUp] ON
INSERT [dbo].[record_FollowUp] ([FollowUpID], [F_PatientID], [F_Type], [F_Date], [F_Status]) VALUES (1, 7, 1, CAST(0x0000A1D400000000 AS DateTime), 3)
INSERT [dbo].[record_FollowUp] ([FollowUpID], [F_PatientID], [F_Type], [F_Date], [F_Status]) VALUES (2, 7, 1, CAST(0x0000A1D300000000 AS DateTime), 3)
INSERT [dbo].[record_FollowUp] ([FollowUpID], [F_PatientID], [F_Type], [F_Date], [F_Status]) VALUES (3, 2, 3, CAST(0x0000A1D500000000 AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[record_FollowUp] OFF
/****** Object:  Table [dbo].[record_FimaryProblem]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_FimaryProblem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_FimaryProblem](
	[F_FimaryCode] [varchar](30) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[F_RecordTime] [datetime] NOT NULL,
	[F_StartTime] [datetime] NOT NULL,
	[F_endTime] [datetime] NULL,
	[F_OverviewProblem] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[F_DetailProblem] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[F_FillingUserID] [int] NOT NULL
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FimaryProblem', N'COLUMN',N'F_FimaryCode'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭编号，与record_FamilybaseInfo中的F_FimaryCode关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_FimaryCode'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FimaryProblem', N'COLUMN',N'F_RecordTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_RecordTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FimaryProblem', N'COLUMN',N'F_StartTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发生时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_StartTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FimaryProblem', N'COLUMN',N'F_endTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_endTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FimaryProblem', N'COLUMN',N'F_OverviewProblem'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'问题概述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_OverviewProblem'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FimaryProblem', N'COLUMN',N'F_DetailProblem'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'问题详述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_DetailProblem'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FimaryProblem', N'COLUMN',N'F_FillingUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档医生' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_FillingUserID'
GO
/****** Object:  Table [dbo].[record_FamilyBaseInfo]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_FamilyBaseInfo](
	[FimaryID] [int] IDENTITY(1,1) NOT NULL,
	[F_FimaryCode] [varchar](30) COLLATE Chinese_PRC_CI_AS NULL,
	[F_UserID] [int] NOT NULL,
	[F_GroupID] [int] NOT NULL,
	[F_FimaryTel] [varchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[F_FimrayAddress] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[F_HouseType] [tinyint] NULL,
	[F_HouseArea] [float] NULL,
	[F_Ventilation] [tinyint] NULL,
	[F_Humidity] [tinyint] NULL,
	[F_Warm] [tinyint] NULL,
	[F_Lighting] [tinyint] NULL,
	[F_Sanitation] [tinyint] NULL,
	[F_Kitchen] [tinyint] NULL,
	[F_Fuel] [tinyint] NULL,
	[F_Water] [tinyint] NULL,
	[F_WasteDisposal] [tinyint] NULL,
	[F_LivestockBar] [tinyint] NULL,
	[F_ToiletType] [tinyint] NULL,
	[F_ResponsibilityUserID] [int] NOT NULL,
	[F_FillingUserID] [int] NOT NULL,
 CONSTRAINT [PK_record_FamilyInfo] PRIMARY KEY CLUSTERED 
(
	[FimaryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'FimaryID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自增家庭ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'FimaryID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_FimaryCode'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭档案编号，由12位居（村）委会行政代码+自增的FimaryID组成' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_FimaryCode'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'户主，与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_GroupID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'村(居)委会ID，与sys_Group表中GroupID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_GroupID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_FimrayAddress'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_FimrayAddress'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_HouseType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'房屋类型 1:砖瓦平房，2:砖瓦楼房，3:土屋，4:茅屋，5:木屋' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_HouseType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_HouseArea'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'居住面积' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_HouseArea'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_Ventilation'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'通风 1:好，2:一般，3:差' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Ventilation'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_Humidity'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'湿度 1:潮湿，2:干燥，3:一般' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Humidity'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_Warm'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保暖 1:好，2:一般，3:差' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Warm'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_Lighting'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'采光 1:好，2:一般，3:差' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Lighting'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_Sanitation'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卫生 1:清洁，2:一般，3:较脏，4:差' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Sanitation'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_Kitchen'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'厨房 1:合用，2:独用，3:无' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Kitchen'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_Fuel'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'使用燃料 1：液化气，2：煤气，3:天然气，4:沼气，5:柴火，6:其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Fuel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_Water'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'饮水来源 1：自来水，2：经净化过滤的水，3：井水，4：河湖水，5：塘水口，6：桶装水，7：其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Water'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_WasteDisposal'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'垃圾处理 1：垃圾处理，2：垃圾箱，3：其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_WasteDisposal'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_LivestockBar'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'禽畜栏 1：单设，2：室内，3：室外' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_LivestockBar'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_ToiletType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'厕所类型 1：家庭卫生厕所：三格式粪池式，2：家庭卫生厕所：双瓮漏斗式，3：家庭卫生厕所：三联沼气池式，4：家庭卫生厕所：粪尿分集式，5：家庭卫生厕所：完整下水道水冲式，6：家庭卫生厕所：双坑交替式，7：非卫生厕所：一格或两格粪池式，8：非卫生厕所：马桶，9：非卫生厕所：露天粪坑，10：非卫生厕所：简易棚厕' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_ToiletType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_ResponsibilityUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'责任人，与sys_User表中的UerID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_ResponsibilityUserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_FamilyBaseInfo', N'COLUMN',N'F_FillingUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档人，与sys_User表中的UerID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_FillingUserID'
GO
/****** Object:  Table [dbo].[record_DeathRegistration]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_DeathRegistration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_DeathRegistration](
	[DeathID] [int] IDENTITY(1,1) NOT NULL,
	[D_DateTime] [datetime] NOT NULL,
	[D_Location] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[D_Icd10ID] [int] NULL,
	[D_Note] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[D_UserID] [int] NOT NULL,
	[D_RegDate] [datetime] NOT NULL,
 CONSTRAINT [PK_record_DeathRegistration] PRIMARY KEY CLUSTERED 
(
	[DeathID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_DeathRegistration', N'COLUMN',N'D_Icd10ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'疾病icd10编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_DeathRegistration', @level2type=N'COLUMN',@level2name=N'D_Icd10ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_DeathRegistration', N'COLUMN',N'D_Note'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'死亡说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_DeathRegistration', @level2type=N'COLUMN',@level2name=N'D_Note'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_DeathRegistration', N'COLUMN',N'D_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登记人,与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_DeathRegistration', @level2type=N'COLUMN',@level2name=N'D_UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_DeathRegistration', N'COLUMN',N'D_RegDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登记日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_DeathRegistration', @level2type=N'COLUMN',@level2name=N'D_RegDate'
GO
/****** Object:  Table [dbo].[record_Consultation]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[record_Consultation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[record_Consultation](
	[ConsultationID] [int] IDENTITY(1,1) NOT NULL,
	[C_UserID] [int] NOT NULL,
	[C_Cause] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[C_Comments] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[C_Time] [datetime] NOT NULL,
	[C_Dortor] [int] NOT NULL,
 CONSTRAINT [PK_record_Consultation] PRIMARY KEY CLUSTERED 
(
	[ConsultationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Consultation', N'COLUMN',N'ConsultationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊流水号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'ConsultationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Consultation', N'COLUMN',N'C_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID，与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Consultation', N'COLUMN',N'C_Cause'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊原因' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_Cause'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Consultation', N'COLUMN',N'C_Comments'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊意见' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_Comments'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Consultation', N'COLUMN',N'C_Time'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_Time'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'record_Consultation', N'COLUMN',N'C_Dortor'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊医生' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_Dortor'
GO
SET IDENTITY_INSERT [dbo].[record_Consultation] ON
INSERT [dbo].[record_Consultation] ([ConsultationID], [C_UserID], [C_Cause], [C_Comments], [C_Time], [C_Dortor]) VALUES (1, 7, N'原因1', N'意见1', CAST(0x0000A1CC00000000 AS DateTime), 1)
INSERT [dbo].[record_Consultation] ([ConsultationID], [C_UserID], [C_Cause], [C_Comments], [C_Time], [C_Dortor]) VALUES (2, 7, N'原因3', N'会诊意见3', CAST(0x0000A1CC00000000 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[record_Consultation] OFF
/****** Object:  Table [dbo].[Nation]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Nation](
	[NationID] [int] IDENTITY(1,1) NOT NULL,
	[N_Name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK__NATION__4924D839] PRIMARY KEY CLUSTERED 
(
	[NationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Nation', N'COLUMN',N'NationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'民族ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Nation', @level2type=N'COLUMN',@level2name=N'NationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Nation', N'COLUMN',N'N_Name'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'民族名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Nation', @level2type=N'COLUMN',@level2name=N'N_Name'
GO
SET IDENTITY_INSERT [dbo].[Nation] ON
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (1, N'汉族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (2, N'蒙古族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (3, N'回族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (4, N'藏族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (5, N'维吾尔族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (6, N'苗族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (7, N'彝族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (8, N'壮族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (9, N'布依族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (10, N'朝鲜族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (11, N'满族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (12, N'侗族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (13, N'瑶族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (14, N'白族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (15, N'土家族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (16, N'哈尼族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (17, N'哈萨克族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (18, N'傣族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (19, N'黎族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (20, N'傈僳族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (21, N'佤族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (22, N'畲族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (23, N'高山族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (24, N'拉祜族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (25, N'水族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (26, N'东乡族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (27, N'纳西族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (28, N'景颇族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (29, N'柯尔克孜族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (30, N'土族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (31, N'达斡尔族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (32, N'仫佬族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (33, N'羌族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (34, N'布朗族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (35, N'撒拉族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (36, N'毛难族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (37, N'仡佬族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (38, N'锡伯族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (39, N'阿昌族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (40, N'普米族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (41, N'塔吉克族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (42, N'怒族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (43, N'乌孜别克族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (44, N'俄罗斯族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (45, N'鄂温克族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (46, N'崩龙族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (47, N'保安族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (48, N'裕固族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (49, N'京族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (50, N'塔塔尔族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (51, N'独龙族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (52, N'鄂伦春族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (53, N'赫哲族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (54, N'门巴族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (55, N'珞巴族')
INSERT [dbo].[Nation] ([NationID], [N_Name]) VALUES (56, N'基诺族')
SET IDENTITY_INSERT [dbo].[Nation] OFF
/****** Object:  Table [dbo].[extend_GeneticDisease]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_GeneticDisease]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[extend_GeneticDisease](
	[GeneticDiseaseID] [int] IDENTITY(1,1) NOT NULL,
	[GD_Name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[GD_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_GeneticDisease] PRIMARY KEY CLUSTERED 
(
	[GeneticDiseaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_GeneticDisease', N'COLUMN',N'GeneticDiseaseID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'遗传病ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_GeneticDisease', @level2type=N'COLUMN',@level2name=N'GeneticDiseaseID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_GeneticDisease', N'COLUMN',N'GD_Name'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'遗传病名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_GeneticDisease', @level2type=N'COLUMN',@level2name=N'GD_Name'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_GeneticDisease', N'COLUMN',N'GD_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_GeneticDisease', @level2type=N'COLUMN',@level2name=N'GD_UserID'
GO
SET IDENTITY_INSERT [dbo].[extend_GeneticDisease] ON
INSERT [dbo].[extend_GeneticDisease] ([GeneticDiseaseID], [GD_Name], [GD_UserID]) VALUES (1, N'cest', 7)
SET IDENTITY_INSERT [dbo].[extend_GeneticDisease] OFF
/****** Object:  Table [dbo].[extend_FamilyHistory]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_FamilyHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[extend_FamilyHistory](
	[FamilyHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[FH_Type] [tinyint] NOT NULL,
	[FH_Who] [tinyint] NOT NULL,
	[FH_Note] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[FH_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_FamilyHistory] PRIMARY KEY CLUSTERED 
(
	[FamilyHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_FamilyHistory', N'COLUMN',N'FamilyHistoryID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家族史ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FamilyHistoryID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_FamilyHistory', N'COLUMN',N'FH_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'常见疾病，与commonDisease表的commonDisease相对应' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FH_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_FamilyHistory', N'COLUMN',N'FH_Who'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭成员角色：1父亲、2母亲、3兄弟姐妹、4儿女' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FH_Who'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_FamilyHistory', N'COLUMN',N'FH_Note'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FH_Note'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_FamilyHistory', N'COLUMN',N'FH_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FH_UserID'
GO
SET IDENTITY_INSERT [dbo].[extend_FamilyHistory] ON
INSERT [dbo].[extend_FamilyHistory] ([FamilyHistoryID], [FH_Type], [FH_Who], [FH_Note], [FH_UserID]) VALUES (1, 1, 2, N'', 7)
INSERT [dbo].[extend_FamilyHistory] ([FamilyHistoryID], [FH_Type], [FH_Who], [FH_Note], [FH_UserID]) VALUES (2, 2, 1, N'', 7)
INSERT [dbo].[extend_FamilyHistory] ([FamilyHistoryID], [FH_Type], [FH_Who], [FH_Note], [FH_UserID]) VALUES (7, 4, 3, N'', 7)
INSERT [dbo].[extend_FamilyHistory] ([FamilyHistoryID], [FH_Type], [FH_Who], [FH_Note], [FH_UserID]) VALUES (8, 8, 1, N'', 7)
INSERT [dbo].[extend_FamilyHistory] ([FamilyHistoryID], [FH_Type], [FH_Who], [FH_Note], [FH_UserID]) VALUES (9, 9, 2, N'', 7)
INSERT [dbo].[extend_FamilyHistory] ([FamilyHistoryID], [FH_Type], [FH_Who], [FH_Note], [FH_UserID]) VALUES (10, 3, 4, N'', 7)
INSERT [dbo].[extend_FamilyHistory] ([FamilyHistoryID], [FH_Type], [FH_Who], [FH_Note], [FH_UserID]) VALUES (14, 11, 2, N'ett4t', 7)
INSERT [dbo].[extend_FamilyHistory] ([FamilyHistoryID], [FH_Type], [FH_Who], [FH_Note], [FH_UserID]) VALUES (15, 11, 1, N'dvwedw', 7)
SET IDENTITY_INSERT [dbo].[extend_FamilyHistory] OFF
/****** Object:  Table [dbo].[extend_Environment]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_Environment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[extend_Environment](
	[EnvironmentID] [int] IDENTITY(1,1) NOT NULL,
	[E_Kind] [tinyint] NOT NULL,
	[E_Type] [tinyint] NOT NULL,
	[E_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_Environment] PRIMARY KEY CLUSTERED 
(
	[EnvironmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_Environment', N'COLUMN',N'E_Kind'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'种类：1 厨房排风设施，2 燃料类型，3 饮水，4 厕所，5 禽畜栏' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Environment', @level2type=N'COLUMN',@level2name=N'E_Kind'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_Environment', N'COLUMN',N'E_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型，和E_Kind一起才能确定：1-1 无，1-2 油烟机,1-3 换气扇，1-4 烟囱；2-1 液化气，2-2 煤气，2-3 天然气，2-4 沼气，2-5 柴火，2-6 其他；3-1 自来水，3-2 经净化过滤的水，3-3 井水，3-4 河湖水，3-5 糖水，3-6 其他；4-1 卫生厕所，4-2 一格或两格粪池式，4-3 马桶，4-4 露天粪坑，4-5 简易棚厕； 5-1 单设，5-2 室内，5-3 室外；' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Environment', @level2type=N'COLUMN',@level2name=N'E_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_Environment', N'COLUMN',N'E_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Environment', @level2type=N'COLUMN',@level2name=N'E_UserID'
GO
SET IDENTITY_INSERT [dbo].[extend_Environment] ON
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (2, 2, 3, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (4, 1, 4, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (5, 2, 1, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (6, 2, 6, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (7, 3, 1, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (8, 3, 6, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (9, 4, 1, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (10, 4, 5, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (11, 5, 1, 7)
INSERT [dbo].[extend_Environment] ([EnvironmentID], [E_Kind], [E_Type], [E_UserID]) VALUES (12, 5, 3, 7)
SET IDENTITY_INSERT [dbo].[extend_Environment] OFF
/****** Object:  Table [dbo].[extend_DiseaseOther]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_DiseaseOther]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[extend_DiseaseOther](
	[DiseaseOtherID] [int] IDENTITY(1,1) NOT NULL,
	[DO_Type] [tinyint] NOT NULL,
	[DO_Date] [date] NOT NULL,
	[DO_Name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[DO_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_DiseaseOther] PRIMARY KEY CLUSTERED 
(
	[DiseaseOtherID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseOther', N'COLUMN',N'DO_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型，1 手上, 2 外伤, 3 输血' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseOther', @level2type=N'COLUMN',@level2name=N'DO_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseOther', N'COLUMN',N'DO_Date'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseOther', @level2type=N'COLUMN',@level2name=N'DO_Date'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseOther', N'COLUMN',N'DO_Name'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseOther', @level2type=N'COLUMN',@level2name=N'DO_Name'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseOther', N'COLUMN',N'DO_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseOther', @level2type=N'COLUMN',@level2name=N'DO_UserID'
GO
SET IDENTITY_INSERT [dbo].[extend_DiseaseOther] ON
INSERT [dbo].[extend_DiseaseOther] ([DiseaseOtherID], [DO_Type], [DO_Date], [DO_Name], [DO_UserID]) VALUES (4, 2, CAST(0x1F370B00 AS Date), N'外伤1', 7)
INSERT [dbo].[extend_DiseaseOther] ([DiseaseOtherID], [DO_Type], [DO_Date], [DO_Name], [DO_UserID]) VALUES (5, 3, CAST(0x11370B00 AS Date), N'输血1', 7)
INSERT [dbo].[extend_DiseaseOther] ([DiseaseOtherID], [DO_Type], [DO_Date], [DO_Name], [DO_UserID]) VALUES (7, 1, CAST(0x0C370B00 AS Date), N'手术1', 7)
SET IDENTITY_INSERT [dbo].[extend_DiseaseOther] OFF
/****** Object:  Table [dbo].[extend_DiseaseHistory]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_DiseaseHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[extend_DiseaseHistory](
	[DiseaseHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[DH_Type] [tinyint] NOT NULL,
	[DH_DiagnosisDate] [date] NOT NULL,
	[DH_Note] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[DH_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_DiseaseHistory] PRIMARY KEY CLUSTERED 
(
	[DiseaseHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseHistory', N'COLUMN',N'DiseaseHistoryID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'疾病史ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DiseaseHistoryID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseHistory', N'COLUMN',N'DH_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'常见疾病，与commonDisease表的commonDisease相对应' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DH_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseHistory', N'COLUMN',N'DH_DiagnosisDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'确诊日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DH_DiagnosisDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseHistory', N'COLUMN',N'DH_Note'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DH_Note'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_DiseaseHistory', N'COLUMN',N'DH_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DH_UserID'
GO
SET IDENTITY_INSERT [dbo].[extend_DiseaseHistory] ON
INSERT [dbo].[extend_DiseaseHistory] ([DiseaseHistoryID], [DH_Type], [DH_DiagnosisDate], [DH_Note], [DH_UserID]) VALUES (7, 1, CAST(0x26370B00 AS Date), N'', 7)
INSERT [dbo].[extend_DiseaseHistory] ([DiseaseHistoryID], [DH_Type], [DH_DiagnosisDate], [DH_Note], [DH_UserID]) VALUES (9, 2, CAST(0x20370B00 AS Date), N'', 7)
INSERT [dbo].[extend_DiseaseHistory] ([DiseaseHistoryID], [DH_Type], [DH_DiagnosisDate], [DH_Note], [DH_UserID]) VALUES (10, 11, CAST(0x20370B00 AS Date), N'', 7)
SET IDENTITY_INSERT [dbo].[extend_DiseaseHistory] OFF
/****** Object:  Table [dbo].[extend_Disability]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[extend_Disability]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[extend_Disability](
	[DisabilityID] [int] IDENTITY(1,1) NOT NULL,
	[D_Type] [tinyint] NOT NULL,
	[D_Note] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[D_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_Disability] PRIMARY KEY CLUSTERED 
(
	[DisabilityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_Disability', N'COLUMN',N'DisabilityID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'残疾情况ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Disability', @level2type=N'COLUMN',@level2name=N'DisabilityID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_Disability', N'COLUMN',N'D_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'残疾类型：0无，1视力残疾，2听力残疾，3言语残疾，4体残疾，5智力残疾，6精神残疾，7其他+备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Disability', @level2type=N'COLUMN',@level2name=N'D_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_Disability', N'COLUMN',N'D_Note'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Disability', @level2type=N'COLUMN',@level2name=N'D_Note'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'extend_Disability', N'COLUMN',N'D_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Disability', @level2type=N'COLUMN',@level2name=N'D_UserID'
GO
SET IDENTITY_INSERT [dbo].[extend_Disability] ON
INSERT [dbo].[extend_Disability] ([DisabilityID], [D_Type], [D_Note], [D_UserID]) VALUES (2, 3, N'', 7)
INSERT [dbo].[extend_Disability] ([DisabilityID], [D_Type], [D_Note], [D_UserID]) VALUES (3, 1, N'', 7)
INSERT [dbo].[extend_Disability] ([DisabilityID], [D_Type], [D_Note], [D_UserID]) VALUES (5, 6, N'', 7)
INSERT [dbo].[extend_Disability] ([DisabilityID], [D_Type], [D_Note], [D_UserID]) VALUES (6, 7, N'', 7)
SET IDENTITY_INSERT [dbo].[extend_Disability] OFF
/****** Object:  Table [dbo].[education_Prescription]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[education_Prescription]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[education_Prescription](
	[PrescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[P_Object] [money] NOT NULL,
	[P_Name] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[P_Content] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[P_Doctor] [int] NOT NULL,
	[P_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_education_Prescription] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Prescription', N'COLUMN',N'PrescriptionID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康处方ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'PrescriptionID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Prescription', N'COLUMN',N'P_Object'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康处方对象，与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Object'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Prescription', N'COLUMN',N'P_Name'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处方名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Name'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Prescription', N'COLUMN',N'P_Content'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处方内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Content'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Prescription', N'COLUMN',N'P_Doctor'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处方医生，，与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Doctor'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Prescription', N'COLUMN',N'P_Date'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处方日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Date'
GO
/****** Object:  Table [dbo].[education_Document]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[education_Document]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[education_Document](
	[DocumentID] [int] IDENTITY(1,1) NOT NULL,
	[D_Name] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[D_Url] [varchar](2038) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_education_Document] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Document', N'COLUMN',N'DocumentID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康知识文档ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Document', @level2type=N'COLUMN',@level2name=N'DocumentID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Document', N'COLUMN',N'D_Name'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康知识文档名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Document', @level2type=N'COLUMN',@level2name=N'D_Name'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Document', N'COLUMN',N'D_Url'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康知识文档地址，最大不超过2038个字符（IE）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Document', @level2type=N'COLUMN',@level2name=N'D_Url'
GO
/****** Object:  Table [dbo].[education_Activity]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[education_Activity]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[education_Activity](
	[ActivityID] [int] IDENTITY(1,1) NOT NULL,
	[A_DateTime] [datetime] NOT NULL,
	[A_Location] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[A_Form] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[A_Object] [int] NOT NULL,
	[A_Crowd] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[A_Duration] [int] NULL,
	[A_Organizers] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[A_Partners] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[A_Missionary] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[A_Number] [int] NULL,
	[A_Theme] [text] COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_education_Activity] PRIMARY KEY CLUSTERED 
(
	[ActivityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'ActivityID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康教育活动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'ActivityID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_DateTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'活动时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_DateTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Location'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'活动地点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Location'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Form'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'活动形式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Form'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Object'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'居委会ID，与sys_Group表的GroupID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Object'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Crowd'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'参与人群' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Crowd'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Duration'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'持续时间（min）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Duration'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Organizers'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主办单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Organizers'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Partners'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合作伙伴' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Partners'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Missionary'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'宣教人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Missionary'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Number'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'参与人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Number'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'education_Activity', N'COLUMN',N'A_Theme'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'活动主题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Theme'
GO
SET IDENTITY_INSERT [dbo].[education_Activity] ON
INSERT [dbo].[education_Activity] ([ActivityID], [A_DateTime], [A_Location], [A_Form], [A_Object], [A_Crowd], [A_Duration], [A_Organizers], [A_Partners], [A_Missionary], [A_Number], [A_Theme]) VALUES (3, CAST(0x0000A1D200000000 AS DateTime), N'小区花园', N'宣讲会', 7, N'高血压患者', 90, N'居委会', N'', N'', 0, N'健康教育')
INSERT [dbo].[education_Activity] ([ActivityID], [A_DateTime], [A_Location], [A_Form], [A_Object], [A_Crowd], [A_Duration], [A_Organizers], [A_Partners], [A_Missionary], [A_Number], [A_Theme]) VALUES (6, CAST(0x0000A1D400000000 AS DateTime), N'小区22', N'讲座', 5, N'高血压', 60, N'居委会', N'加多宝', N'乐嘉', 110, N'测试')
SET IDENTITY_INSERT [dbo].[education_Activity] OFF
/****** Object:  Table [dbo].[commonDiseases]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[commonDiseases]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[commonDiseases](
	[CommonDiseaseID] [int] IDENTITY(1,1) NOT NULL,
	[CD_Name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_CommonDiseases] PRIMARY KEY CLUSTERED 
(
	[CommonDiseaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'commonDiseases', N'COLUMN',N'CD_Name'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'常见疾病名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'commonDiseases', @level2type=N'COLUMN',@level2name=N'CD_Name'
GO
SET IDENTITY_INSERT [dbo].[commonDiseases] ON
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (1, N'高血压')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (2, N'糖尿病')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (3, N'冠心病')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (4, N'慢性阻塞性肺疾病')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (5, N'恶性肿瘤')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (6, N'脑卒中')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (7, N'中性精神疾病')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (8, N'结核病')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (9, N'肝炎')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (10, N'先天畸形')
INSERT [dbo].[commonDiseases] ([CommonDiseaseID], [CD_Name]) VALUES (11, N'其他')
SET IDENTITY_INSERT [dbo].[commonDiseases] OFF
/****** Object:  Table [dbo].[AR_Report]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AR_Report]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AR_Report](
	[ReportID] [int] IDENTITY(1,1) NOT NULL,
	[R_Title] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[R_Content] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[R_DateTime] [datetime] NULL,
	[R_ResponsibilityUserID] [int] NULL,
 CONSTRAINT [PK_AR_Report] PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Report', N'COLUMN',N'ReportID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'ReportID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Report', N'COLUMN',N'R_Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'R_Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Report', N'COLUMN',N'R_Content'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'R_Content'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Report', N'COLUMN',N'R_DateTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'R_DateTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Report', N'COLUMN',N'R_ResponsibilityUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'责任人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'R_ResponsibilityUserID'
GO
/****** Object:  Table [dbo].[AR_Announcement]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AR_Announcement]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AR_Announcement](
	[AnnouncementID] [int] IDENTITY(1,1) NOT NULL,
	[A_Title] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[A_Content] [text] COLLATE Chinese_PRC_CI_AS NULL,
	[A_DateTime] [datetime] NOT NULL,
	[A_ResponsibilityUserID] [int] NOT NULL,
	[A_Type] [tinyint] NOT NULL,
 CONSTRAINT [PK_AR_Announcement] PRIMARY KEY CLUSTERED 
(
	[AnnouncementID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Announcement', N'COLUMN',N'AnnouncementID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'AnnouncementID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Announcement', N'COLUMN',N'A_Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Announcement', N'COLUMN',N'A_Content'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_Content'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Announcement', N'COLUMN',N'A_DateTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_DateTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Announcement', N'COLUMN',N'A_ResponsibilityUserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'责任人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_ResponsibilityUserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'AR_Announcement', N'COLUMN',N'A_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告类型，1：普通公告，2：重大疫情公告' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_Type'
GO
SET IDENTITY_INSERT [dbo].[AR_Announcement] ON
INSERT [dbo].[AR_Announcement] ([AnnouncementID], [A_Title], [A_Content], [A_DateTime], [A_ResponsibilityUserID], [A_Type]) VALUES (1, N'测试标题', N'测试内容', CAST(0x0000A1DB00000000 AS DateTime), 7, 1)
SET IDENTITY_INSERT [dbo].[AR_Announcement] OFF
/****** Object:  Table [dbo].[sys_Event]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Event]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Event](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[E_U_LoginName] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[E_UserID] [int] NULL,
	[E_DateTime] [datetime] NOT NULL,
	[E_ApplicationID] [int] NULL,
	[E_A_AppName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[E_M_Name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[E_M_PageCode] [varchar](6) COLLATE Chinese_PRC_CI_AS NULL,
	[E_From] [nvarchar](500) COLLATE Chinese_PRC_CI_AS NULL,
	[E_Type] [tinyint] NOT NULL,
	[E_IP] [varchar](15) COLLATE Chinese_PRC_CI_AS NULL,
	[E_Record] [nvarchar](500) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_SYS_EVENT] PRIMARY KEY NONCLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'EventID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'事件ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'EventID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_U_LoginName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_U_LoginName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作时用户ID与sys_Users中UserID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_DateTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'事件发生的日期及时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_DateTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_ApplicationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属应用程序ID与sys_Applicatio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_ApplicationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_A_AppName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属应用名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_A_AppName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_M_Name'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PageCode模块名称与sys_Module相同' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_M_Name'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_M_PageCode'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发生事件时模块名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_M_PageCode'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_From'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_From'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日记类型,1:操作日记2:安全日志3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_IP'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户端IP地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_IP'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', N'COLUMN',N'E_Record'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'详细描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_Record'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Event', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统日记表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event'
GO
SET IDENTITY_INSERT [dbo].[sys_Event] ON
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (1, N'', 0, CAST(0x0000A1A8017C2D85 AS DateTime), 0, N'', N'', N'', N'/Supesoft1.9/Manager/Login.aspx?ReturnUrl=%2fSupesoft1.9%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'用户名/密码(admin/admin)错误！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (2, N'', 0, CAST(0x0000A1A8017C366F AS DateTime), 0, N'', N'', N'', N'/Supesoft1.9/Manager/login.aspx', 2, N'127.0.0.1', N'用户名/密码(admin/addmin)错误！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (3, N'admin', 1, CAST(0x0000A1A8017D2959 AS DateTime), 0, N'', N'', N'', N'/Supesoft1.9/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (4, N'', 0, CAST(0x0000A1A8017FBE66 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013-04-22 23:07:45),从(127.0.0.1)IP登陆在本系统.在线时间:0.90分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (5, N'admin', 1, CAST(0x0000A1A8017FC9C0 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=8213&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (6, N'admin', 1, CAST(0x0000A1A8017FC9ED AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=8213&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (17, N'admin', 1, CAST(0x0000A1A90000B1B6 AS DateTime), 0, N'', N'', N'', N'/Manager/LoginOut.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (18, N'admin', 1, CAST(0x0000A1A90000C145 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (22, N'admin', 1, CAST(0x0000A1A901632225 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (23, N'admin', 1, CAST(0x0000A1A90164B448 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/moduleManager.aspx?CMD=New&S_ID=1&ModuleId=0', 1, N'127.0.0.1', N'增加/修改模块ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (24, N'admin', 1, CAST(0x0000A1A901652B9F AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=31&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(31)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (26, N'admin', 1, CAST(0x0000A1A901669BC0 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=32&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(32)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (27, N'admin', 1, CAST(0x0000A1A90166A773 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand10246914', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (28, N'admin', 1, CAST(0x0000A1A90166B939 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand95631002', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (42, N'', 0, CAST(0x0000A1A9016BBB1C AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'用户名/密码(test/12456)错误！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (43, N'test', 2, CAST(0x0000A1A9016BC2A2 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您test，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (44, N'test', 2, CAST(0x0000A1A9016BD37F AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand65137175', 1, N'127.0.0.1', N'(test)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (45, N'admin', 1, CAST(0x0000A1A9017FC917 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=Edit&RoleID=1', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (46, N'admin', 1, CAST(0x0000A1A9017FC918 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=Edit&RoleID=1', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (47, N'admin', 1, CAST(0x0000A1A901808B87 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (48, N'admin', 1, CAST(0x0000A1AA017AE771 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (49, N'admin', 1, CAST(0x0000A1AA017B2D2C AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand23449932', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (50, N'admin', 1, CAST(0x0000A1AA017B4882 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand58165295', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (51, N'admin', 1, CAST(0x0000A1AA017B555A AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand99835391', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (52, N'admin', 1, CAST(0x0000A1AA017B6224 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand5922497', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (53, N'admin', 1, CAST(0x0000A1AA017B69E7 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand43583677', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (54, N'admin', 1, CAST(0x0000A1AA017C4CCF AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand50049726', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (55, N'admin', 1, CAST(0x0000A1AB0162C16D AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (56, N'admin', 1, CAST(0x0000A1AB0168CD33 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=0', 1, N'127.0.0.1', N'增加部门(信息科)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (57, N'admin', 1, CAST(0x0000A1AB016939AB AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=Edit&UserID=2', 1, N'127.0.0.1', N'修改ID(test)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (58, N'admin', 1, CAST(0x0000A1AB016969D4 AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=Edit&UserID=2', 1, N'127.0.0.1', N'修改ID(test)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (59, N'admin', 1, CAST(0x0000A1AB018405B1 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=Look&RoleID=1', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (60, N'admin', 1, CAST(0x0000A1AB0184060B AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=Look&RoleID=1', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (61, N'admin', 1, CAST(0x0000A1AB01841410 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (62, N'admin', 1, CAST(0x0000A1AD00013B32 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (7, N'admin', 1, CAST(0x0000A1A80188F0D8 AS DateTime), 1, N'基础模组', N'在线用户列表', N'S00M06', N'/Manager/Module/FrameWork/SystemApp/OnlineUserManager/default.aspx', 2, N'127.0.0.1', N'强制用户(admin)退出成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (8, N'admin', 1, CAST(0x0000A1A80188F0E0 AS DateTime), 0, N'', N'', N'', N'/Manager/Messages.aspx?OPID=04742', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (9, N'admin', 1, CAST(0x0000A1A80188F0E1 AS DateTime), 0, N'', N'', N'', N'/Manager/Messages.aspx?OPID=04742', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (10, N'admin', 1, CAST(0x0000A1A80189034A AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (11, N'admin', 1, CAST(0x0000A1A8018B0888 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand57728053', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (12, N'admin', 1, CAST(0x0000A1A8018B2E5A AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand4207819', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (13, N'admin', 1, CAST(0x0000A1A8018B4F91 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand20965793', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (14, N'admin', 1, CAST(0x0000A1A8018B60DC AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand14746228', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (15, N'admin', 1, CAST(0x0000A1A8018B6861 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand82851509', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (16, N'admin', 1, CAST(0x0000A1A8018B7104 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand10341221', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (19, N'admin', 1, CAST(0x0000A1A900061E4A AS DateTime), 1, N'基础模组', N'系统运行状态', N'S01M00', N'/Manager/Module/FrameWork/SystemMaintenance/SystemState/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (63, N'admin', 1, CAST(0x0000A1AD01634DCB AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (64, N'admin', 1, CAST(0x0000A1AD01713629 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/Edit.aspx?GroupID=1', 1, N'127.0.0.1', N'修改部门ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (65, N'admin', 1, CAST(0x0000A1AD01714919 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=1', 1, N'127.0.0.1', N'增加部门(茂名市)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (66, N'admin', 1, CAST(0x0000A1AD017157D5 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=3', 1, N'127.0.0.1', N'增加部门(茂港区)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (67, N'admin', 1, CAST(0x0000A1AD01717340 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=4', 1, N'127.0.0.1', N'增加部门(禄段村委会)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (68, N'admin', 1, CAST(0x0000A1AD0171A75A AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=Edit&UserID=2', 1, N'127.0.0.1', N'修改ID(test)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (69, N'admin', 1, CAST(0x0000A1AD01727B15 AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=Edit&UserID=1', 1, N'127.0.0.1', N'修改ID(admin)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (70, N'admin', 1, CAST(0x0000A1AF00B8A4D5 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (71, N'admin', 1, CAST(0x0000A1B3016C5A29 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (72, N'', 0, CAST(0x0000A1B500D22D97 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'用户名/密码(admin/123456)错误！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (73, N'admin', 1, CAST(0x0000A1B500D2351E AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (74, N'', 0, CAST(0x0000A1B500D5DC21 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013-05-05 12:45:20),从(127.0.0.1)IP登陆在本系统.在线时间:1.97分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (76, N'admin', 1, CAST(0x0000A1B500D5F66C AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=2556&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (77, N'admin', 1, CAST(0x0000A1B500D5F679 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=2556&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (78, N'admin', 1, CAST(0x0000A1B500F15374 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/GroupList.aspx?GroupID=4', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (79, N'admin', 1, CAST(0x0000A1B500F153FF AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/GroupList.aspx?GroupID=4', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (80, N'admin', 1, CAST(0x0000A1B500F160E4 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (81, N'admin', 1, CAST(0x0000A1B500FBA240 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=1&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (82, N'admin', 1, CAST(0x0000A1B500FBBB16 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=1&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (86, N'admin', 1, CAST(0x0000A1B501009B8F AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (89, N'admin', 1, CAST(0x0000A1B50101F4B5 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (95, N'', 0, CAST(0x0000A1B50105CAC7 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013-05-05 14:38:49),从(127.0.0.1)IP登陆在本系统.在线时间:72.70分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (20, N'admin', 1, CAST(0x0000A1A900071F6D AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (21, N'admin', 1, CAST(0x0000A1A90009EBDE AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=0', 1, N'127.0.0.1', N'增加部门(人事部)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (75, N'', 0, CAST(0x0000A1B500D5F42C AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013-05-05 12:45:20),从(127.0.0.1)IP登陆在本系统.在线时间:1.97分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (96, N'admin', 1, CAST(0x0000A1B50105CD96 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=5374&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (97, N'admin', 1, CAST(0x0000A1B50105CDC0 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=5374&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (98, N'admin', 1, CAST(0x0000A1B50106B0D3 AS DateTime), 0, N'', N'', N'', N'/Manager/Menu2.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (99, N'admin', 1, CAST(0x0000A1B50106B0DC AS DateTime), 0, N'', N'', N'', N'/Manager/Menu2.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (102, N'admin', 1, CAST(0x0000A1B5010F8183 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=31&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(31)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (106, N'admin', 1, CAST(0x0000A1B5011276D0 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/modulemanager.aspx?CMD=New&ModuleID=31&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(31)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (107, N'admin', 1, CAST(0x0000A1B5011388B3 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=46&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(46)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (108, N'admin', 1, CAST(0x0000A1B50113F8EC AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/moduleManager.aspx?CMD=New&S_ID=1&ModuleId=0', 1, N'127.0.0.1', N'存在相同的模块编码(S03)')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (109, N'admin', 1, CAST(0x0000A1B50113FF0B AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/moduleManager.aspx?CMD=New&S_ID=1&ModuleId=0', 1, N'127.0.0.1', N'增加/修改模块ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (110, N'admin', 1, CAST(0x0000A1B50116A378 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=47&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(47)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (111, N'admin', 1, CAST(0x0000A1B50116D231 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=47&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(47)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (112, N'admin', 1, CAST(0x0000A1B50116FDA6 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=47&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(47)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (113, N'admin', 1, CAST(0x0000A1B501172942 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=50&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(50)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (114, N'admin', 1, CAST(0x0000A1B501177DBD AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=48&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(48)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (115, N'admin', 1, CAST(0x0000A1B50117A050 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=49&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(49)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (116, N'admin', 1, CAST(0x0000A1B50117DFBC AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=48&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(48)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (117, N'admin', 1, CAST(0x0000A1B50117ED2B AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=50&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(50)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (118, N'admin', 1, CAST(0x0000A1B5011B59A6 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/moduleManager.aspx?CMD=New&S_ID=1&ModuleId=0', 1, N'127.0.0.1', N'增加/修改模块ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (119, N'admin', 1, CAST(0x0000A1B5011B959B AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=51&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(51)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (120, N'admin', 1, CAST(0x0000A1B5011BCE6A AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=51&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(51)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (121, N'admin', 1, CAST(0x0000A1B5011C021F AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=51&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(51)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (122, N'admin', 1, CAST(0x0000A1B5011C127A AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=52&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(52)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (127, N'admin', 1, CAST(0x0000A1B5011DC2F2 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=57&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(57)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (128, N'admin', 1, CAST(0x0000A1B60163E53A AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (25, N'admin', 1, CAST(0x0000A1A9016639E1 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=31&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(31)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (29, N'admin', 1, CAST(0x0000A1A9016A7571 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (30, N'admin', 1, CAST(0x0000A1A9016A8787 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (31, N'admin', 1, CAST(0x0000A1A9016A9460 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (32, N'admin', 1, CAST(0x0000A1A9016AA00D AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
GO
print 'Processed 100 total records'
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (33, N'admin', 1, CAST(0x0000A1A9016AAD03 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (34, N'admin', 1, CAST(0x0000A1A9016AB849 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (35, N'admin', 1, CAST(0x0000A1A9016AC2E9 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (36, N'admin', 1, CAST(0x0000A1A9016ACF25 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (37, N'admin', 1, CAST(0x0000A1A9016B195A AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加ID(test)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (38, N'admin', 1, CAST(0x0000A1A9016B31B8 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?RoleID=1&CMD=Look', 1, N'127.0.0.1', N'增加角色应用ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (39, N'admin', 1, CAST(0x0000A1A9016B5CC5 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RolePermissionManager.aspx?RoleID=1&ApplicationID=1&CMD=Edit', 1, N'127.0.0.1', N'修改角色(1)应用(1)权限成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (40, N'admin', 1, CAST(0x0000A1A9016B8517 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?RoleID=1&CMD=Look', 1, N'127.0.0.1', N'从角色ID:1中增加用户ID:1成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (41, N'admin', 1, CAST(0x0000A1A9016B9C28 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?RoleID=1&UserID=1&CMD=MoveUser', 1, N'127.0.0.1', N'从角色ID:1中移除用户ID:1成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (129, N'', 0, CAST(0x0000A1B60170FF2C AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013-05-06 21:35:46),从(127.0.0.1)IP登陆在本系统.在线时间:31.13分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (130, N'admin', 1, CAST(0x0000A1B6017102B9 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=2133&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (131, N'admin', 1, CAST(0x0000A1B6017102C8 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=2133&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (133, N'admin', 1, CAST(0x0000A1B60175F808 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=3', 1, N'127.0.0.1', N'增加部门(高州市)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (135, N'admin', 1, CAST(0x0000A1B7015E6608 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (136, N'test', 2, CAST(0x0000A1B70161B643 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您test，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (137, N'admin', 1, CAST(0x0000A1B7016DBEB5 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand7484568', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (138, N'admin', 1, CAST(0x0000A1B7016F08A4 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand75108025', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (139, N'admin', 1, CAST(0x0000A1B7016F3C51 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand8091993', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (144, N'admin', 1, CAST(0x0000A1B800128479 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleList.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (145, N'admin', 1, CAST(0x0000A1B800128492 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleList.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (146, N'admin', 1, CAST(0x0000A1B800129428 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (147, N'admin', 1, CAST(0x0000A1B8001A0906 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RolePermissionManager.aspx?RoleID=1&ApplicationID=1&CMD=Edit', 1, N'127.0.0.1', N'修改角色(1)应用(1)权限成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (148, N'test', 2, CAST(0x0000A1B8001A0E3A AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (149, N'test', 2, CAST(0x0000A1B8001A0E3B AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (150, N'test', 2, CAST(0x0000A1B8001A116F AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您test，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (151, N'admin', 1, CAST(0x0000A1B8001A2C54 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RolePermissionManager.aspx?RoleID=1&ApplicationID=1&CMD=Edit', 1, N'127.0.0.1', N'修改角色(1)应用(1)权限成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (83, N'admin', 1, CAST(0x0000A1B500FE7252 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/moduleManager.aspx?CMD=New&S_ID=1&ModuleId=0', 2, N'127.0.0.1', N'ctl00$PageBody$M_PageCode字段值：统计分析数据类型必需为英文或数字!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (84, N'admin', 1, CAST(0x0000A1B500FEA32A AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/moduleManager.aspx?CMD=New&S_ID=1&ModuleId=0', 1, N'127.0.0.1', N'增加/修改模块ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (85, N'admin', 1, CAST(0x0000A1B500FED699 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (87, N'admin', 1, CAST(0x0000A1B50100FB8F AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (88, N'admin', 1, CAST(0x0000A1B50101594E AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (90, N'admin', 1, CAST(0x0000A1B50104AE71 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (91, N'admin', 1, CAST(0x0000A1B50104E4CA AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (92, N'admin', 1, CAST(0x0000A1B501051140 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (93, N'admin', 1, CAST(0x0000A1B50105375E AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (94, N'admin', 1, CAST(0x0000A1B5010553CD AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=33&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(33)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (100, N'admin', 1, CAST(0x0000A1B5010A678D AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=40&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(40)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (101, N'admin', 1, CAST(0x0000A1B5010B8E40 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=32&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(32)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (103, N'admin', 1, CAST(0x0000A1B50110BCF7 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=31&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(31)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (104, N'admin', 1, CAST(0x0000A1B5011141CD AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=31&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(31)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (105, N'admin', 1, CAST(0x0000A1B501115494 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=44&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(44)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (123, N'admin', 1, CAST(0x0000A1B5011C4DCE AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/moduleManager.aspx?CMD=New&S_ID=1&ModuleId=0', 1, N'127.0.0.1', N'增加/修改模块ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (124, N'admin', 1, CAST(0x0000A1B5011C8EB9 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=55&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(55)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (125, N'admin', 1, CAST(0x0000A1B5011CB176 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=New&ModuleID=55&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(55)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (126, N'admin', 1, CAST(0x0000A1B5011DB115 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=56&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(56)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (132, N'admin', 1, CAST(0x0000A1B60171C04A AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=3', 2, N'127.0.0.1', N'ctl00$PageBody$G_Type字段值：低于系统允许长度1!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (134, N'admin', 1, CAST(0x0000A1B6017A1C1D AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/Edit.aspx?GroupID=2', 1, N'127.0.0.1', N'修改部门ID(2)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (154, N'admin', 1, CAST(0x0000A1BB01014231 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fModule%2fFrameWork%2fHealthSupervision%2fInfo%2fInfoManager.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (155, N'test', 2, CAST(0x0000A1BB01014954 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fModule%2fFrameWork%2fHealthSupervision%2fInfo%2fInfoManager.aspx', 2, N'127.0.0.1', N'欢迎您test，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (157, N'admin', 1, CAST(0x0000A1BB012F761C AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=3', 2, N'127.0.0.1', N'ctl00$PageBody$G_Code字段值：低于系统允许长度1!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (158, N'admin', 1, CAST(0x0000A1BB012F7F3D AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=3', 1, N'127.0.0.1', N'增加部门(化州市)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (140, N'test', 2, CAST(0x0000A1B8000F1017 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (141, N'test', 2, CAST(0x0000A1B8000F102C AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (142, N'', 0, CAST(0x0000A1B8000F1BAA AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'用户名/密码(test/admin)错误！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (143, N'test', 2, CAST(0x0000A1B8000F2479 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您test，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (152, N'test', 2, CAST(0x0000A1B8001BFC95 AS DateTime), 1, N'基础模组', N'巡查登记', N'S06M01', N'/Manager/Module/FrameWork/HealthSupervision/Info/default.aspx', 2, N'127.0.0.1', N'无权访问当前页面！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (153, N'test', 2, CAST(0x0000A1B8001C45E3 AS DateTime), 1, N'基础模组', N'巡查登记', N'S06M01', N'/Manager/Module/FrameWork/HealthSupervision/Info/default.aspx', 2, N'127.0.0.1', N'无权访问当前页面！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (156, N'admin', 1, CAST(0x0000A1BB010306A1 AS DateTime), 1, N'基础模组', N'角色管理', N'S00M02', N'/Manager/Module/FrameWork/SystemApp/RoleManager/RoleManager.aspx?RoleID=1&CMD=Look', 2, N'127.0.0.1', N'ctl00$PageBody$NewAppID字段值：低于系统允许长度1!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (159, N'admin', 1, CAST(0x0000A1BB012F9E86 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=3', 1, N'127.0.0.1', N'增加部门(茂南区)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (160, N'admin', 1, CAST(0x0000A1BB012FBEAD AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=3', 1, N'127.0.0.1', N'增加部门(电白县)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (168, N'admin', 1, CAST(0x0000A1BB016B4243 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?CMD=New', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (169, N'admin', 1, CAST(0x0000A1BB016B426B AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?CMD=New', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (170, N'admin', 1, CAST(0x0000A1BB016B4835 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (171, N'admin', 1, CAST(0x0000A1BB016B6F42 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (172, N'admin', 1, CAST(0x0000A1BB017E4D17 AS DateTime), 0, N'', N'', N'', N'/Manager/Menu2.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (177, N'admin', 1, CAST(0x0000A1BC00DD3157 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fModule%2fFrameWork%2fHealthSupervision%2fInfo%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (178, N'', 0, CAST(0x0000A1BC00DDB624 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013-05-12 13:25:20),从(127.0.0.1)IP登陆在本系统.在线时间:0.33分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (179, N'admin', 1, CAST(0x0000A1BC00DDB8D4 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=0303&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (180, N'admin', 1, CAST(0x0000A1BC00DDB8D4 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=0303&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (181, N'admin', 1, CAST(0x0000A1BC00DDC70D AS DateTime), 0, N'', N'', N'', N'/Manager/LoginOut.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (182, N'admin', 1, CAST(0x0000A1BC00DDC70D AS DateTime), 0, N'', N'', N'', N'/Manager/LoginOut.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (183, N'test', 2, CAST(0x0000A1BC00DDCA4A AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您test，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (184, N'test', 2, CAST(0x0000A1BC00DDF4B1 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand93377915', 1, N'127.0.0.1', N'(test)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (185, N'test', 2, CAST(0x0000A1BC00DE010F AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand90150892', 1, N'127.0.0.1', N'(test)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (186, N'test', 2, CAST(0x0000A1BC00DE087A AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand95061729', 1, N'127.0.0.1', N'(test)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (187, N'admin', 1, CAST(0x0000A1BC00DE16B9 AS DateTime), 0, N'', N'', N'', N'/Manager/UserSet.aspx?rand32496571', 1, N'127.0.0.1', N'(admin)个人资料设定成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (188, N'admin', 1, CAST(0x0000A1BC00F678CF AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx?717357', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (189, N'admin', 1, CAST(0x0000A1BC00F678D7 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx?717357', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (190, N'admin', 1, CAST(0x0000A1BC00F67C80 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (191, N'admin', 1, CAST(0x0000A1BC00FC4522 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?InfoID=1&CMD=Edit', 1, N'127.0.0.1', N'修改角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (192, N'admin', 1, CAST(0x0000A1BC00FC6088 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?CMD=Delete&InfoID=1', 1, N'127.0.0.1', N'删除信息ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (193, N'admin', 1, CAST(0x0000A1BC00FC759A AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (194, N'admin', 1, CAST(0x0000A1BC00FCF300 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?InfoID=2&CMD=Edit', 1, N'127.0.0.1', N'修改角色ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (195, N'admin', 1, CAST(0x0000A1BC011F202A AS DateTime), 1, N'基础模组', N'系统出错日志', N'S01M01', N'/Manager/Module/FrameWork/SystemMaintenance/SystemErrorLog/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (196, N'admin', 1, CAST(0x0000A1BC011F2046 AS DateTime), 1, N'基础模组', N'系统出错日志', N'S01M01', N'/Manager/Module/FrameWork/SystemMaintenance/SystemErrorLog/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (198, N'admin', 1, CAST(0x0000A1BC012E2FD0 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (199, N'admin', 1, CAST(0x0000A1BC012E2FD5 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (161, N'admin', 1, CAST(0x0000A1BB01300A42 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=4', 1, N'127.0.0.1', N'增加部门(羊角镇)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (162, N'admin', 1, CAST(0x0000A1BB01303357 AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/Move.aspx?CMD=Move&GroupID=5&ToGroupID=10', 1, N'127.0.0.1', N'移动部门(禄段村委会)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (163, N'admin', 1, CAST(0x0000A1BB01306FFC AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=6', 1, N'127.0.0.1', N'增加部门(分界镇)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (164, N'admin', 1, CAST(0x0000A1BB0130998F AS DateTime), 1, N'基础模组', N'部门管理', N'S00M01', N'/Manager/Module/FrameWork/SystemApp/GroupManager/New.aspx?GroupID=11', 1, N'127.0.0.1', N'增加部门(分界街居委会)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (165, N'admin', 1, CAST(0x0000A1BB01591B6E AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?CMD=New', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (166, N'admin', 1, CAST(0x0000A1BB01591BA2 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?CMD=New', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (167, N'admin', 1, CAST(0x0000A1BB015922D5 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (203, N'admin', 1, CAST(0x0000A1BD0158D6EA AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (209, N'admin', 1, CAST(0x0000A1BD01880776 AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=Edit&UserID=2', 1, N'127.0.0.1', N'修改ID(test)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (210, N'admin', 1, CAST(0x0000A1BD0188431D AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加ID(test2)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (217, N'test', 2, CAST(0x0000A1BE01652023 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您test，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (218, N'admin', 1, CAST(0x0000A1BE01653E22 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (219, N'admin', 1, CAST(0x0000A1BE0185E696 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (220, N'admin', 1, CAST(0x0000A1BE0185E6A3 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
GO
print 'Processed 200 total records'
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (222, N'admin', 1, CAST(0x0000A1BF01776493 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (226, N'admin', 1, CAST(0x0000A1C0001D6F6D AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加健康档案ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (227, N'admin', 1, CAST(0x0000A1C0016A9052 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (230, N'admin', 1, CAST(0x0000A1C0017267C5 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (232, N'admin', 1, CAST(0x0000A1C0017312B1 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (233, N'admin', 1, CAST(0x0000A1C001731C86 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (234, N'admin', 1, CAST(0x0000A1C001732662 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (245, N'admin', 1, CAST(0x0000A1C1000F8186 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (246, N'admin', 1, CAST(0x0000A1C1000FC824 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (247, N'admin', 1, CAST(0x0000A1C40167EC44 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (249, N'admin', 1, CAST(0x0000A1C40182F556 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (251, N'admin', 1, CAST(0x0000A1C40182F956 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (252, N'admin', 1, CAST(0x0000A1C50162F669 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (253, N'admin', 1, CAST(0x0000A1C6015919EB AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (259, N'', 0, CAST(0x0000A1C60166901F AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013-05-22 21:44:06),从(127.0.0.1)IP登陆在本系统.在线时间:0.94分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (260, N'admin', 1, CAST(0x0000A1C601669303 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=2747&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (261, N'admin', 1, CAST(0x0000A1C60166930D AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=2747&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (173, N'admin', 1, CAST(0x0000A1BB017E4D1C AS DateTime), 0, N'', N'', N'', N'/Manager/Menu2.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (174, N'admin', 1, CAST(0x0000A1BB017E4DA9 AS DateTime), 0, N'', N'', N'', N'/Manager/right.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (175, N'admin', 1, CAST(0x0000A1BB017E4DB1 AS DateTime), 0, N'', N'', N'', N'/Manager/right.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (176, N'admin', 1, CAST(0x0000A1BB017EF024 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (197, N'admin', 1, CAST(0x0000A1BC011F277F AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (201, N'test', 2, CAST(0x0000A1BC01794140 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx?291191?145752?902680', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (202, N'test', 2, CAST(0x0000A1BC017941C2 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx?291191?145752?902680', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (231, N'admin', 1, CAST(0x0000A1C001730314 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (250, N'admin', 1, CAST(0x0000A1C40182F561 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (254, N'', 0, CAST(0x0000A1C601662B4B AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013-05-22 20:56:28),从(127.0.0.1)IP登陆在本系统.在线时间:46.15分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (255, N'admin', 1, CAST(0x0000A1C601662F65 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=3083&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (200, N'admin', 1, CAST(0x0000A1BC012E3665 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (204, N'admin', 1, CAST(0x0000A1BD016A5E90 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (205, N'admin', 1, CAST(0x0000A1BD016A5EFD AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (206, N'admin', 1, CAST(0x0000A1BD016A5F40 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/FamilyRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (207, N'admin', 1, CAST(0x0000A1BD016A5F41 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/FamilyRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (208, N'admin', 1, CAST(0x0000A1BD016A63C2 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (225, N'admin', 1, CAST(0x0000A1C0000A6651 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (237, N'admin', 1, CAST(0x0000A1C1000C9AD6 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (238, N'admin', 1, CAST(0x0000A1C1000CF454 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (239, N'admin', 1, CAST(0x0000A1C1000CFF04 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (240, N'admin', 1, CAST(0x0000A1C1000D09B9 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (248, N'test', 2, CAST(0x0000A1C4016ABF1A AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您test，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (211, N'admin', 1, CAST(0x0000A1BD01885B6E AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=Edit&UserID=3', 1, N'127.0.0.1', N'修改ID(test2)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (212, N'admin', 1, CAST(0x0000A1BD01887C8B AS DateTime), 1, N'基础模组', N'用户管理', N'S00M03', N'/Manager/Module/FrameWork/SystemApp/UserManager/UserManager.aspx?CMD=Edit&UserID=3', 1, N'127.0.0.1', N'修改ID(test2)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (213, N'admin', 1, CAST(0x0000A1BE0011A079 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加信息ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (214, N'admin', 1, CAST(0x0000A1BE0013BF39 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?InfoID=19&CMD=Edit', 1, N'127.0.0.1', N'修改信息ID(19)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (215, N'admin', 1, CAST(0x0000A1BE001B9A0A AS DateTime), 0, N'', N'', N'', N'/Manager/Module/FrameWork/CommonModule/SelectUser.aspx?5364584&GroupID=5&_winid=w4287&_t=242417', 2, N'127.0.0.1', N'U_IDCard_key字段值：44数据类型必需为日期型!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (216, N'admin', 1, CAST(0x0000A1BE001C2187 AS DateTime), 0, N'', N'', N'', N'/Manager/Module/FrameWork/CommonModule/SelectUser.aspx?6208805&GroupID=5&_winid=w4287&_t=8115', 2, N'127.0.0.1', N'U_IDCard_key字段值：44数据类型必需为日期型!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (221, N'admin', 1, CAST(0x0000A1BE0185ECFB AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (223, N'admin', 1, CAST(0x0000A1C0000A5BA7 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (224, N'admin', 1, CAST(0x0000A1C0000A5BEC AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (228, N'admin', 1, CAST(0x0000A1C0016F74ED AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (229, N'admin', 1, CAST(0x0000A1C00171943B AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (235, N'admin', 1, CAST(0x0000A1C1000C5830 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (236, N'admin', 1, CAST(0x0000A1C1000C5889 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (241, N'admin', 1, CAST(0x0000A1C1000DDC26 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (242, N'admin', 1, CAST(0x0000A1C1000E5D5A AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (243, N'admin', 1, CAST(0x0000A1C1000E7810 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (244, N'admin', 1, CAST(0x0000A1C1000F2B30 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (256, N'admin', 1, CAST(0x0000A1C601662F72 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=3083&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (257, N'admin', 1, CAST(0x0000A1C601666D49 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (258, N'admin', 1, CAST(0x0000A1C601666D4F AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (262, N'admin', 1, CAST(0x0000A1C6017C2AB3 AS DateTime), 0, N'', N'', N'', N'/Manager/Messages.aspx?CMD=AppError', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (263, N'admin', 1, CAST(0x0000A1C6017C2ACF AS DateTime), 0, N'', N'', N'', N'/Manager/Messages.aspx?CMD=AppError', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (264, N'admin', 1, CAST(0x0000A1C6017C32BD AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (265, N'admin', 1, CAST(0x0000A1C900E8C510 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (266, N'admin', 1, CAST(0x0000A1C90182CBBA AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (267, N'admin', 1, CAST(0x0000A1CA0114F7F5 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (268, N'admin', 1, CAST(0x0000A1CA012EA19E AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (269, N'admin', 1, CAST(0x0000A1CA012EA247 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (270, N'admin', 1, CAST(0x0000A1CA012EB2CF AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (271, N'admin', 1, CAST(0x0000A1CA014621F4 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (272, N'admin', 1, CAST(0x0000A1CA0178732F AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (273, N'admin', 1, CAST(0x0000A1CA01787357 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (274, N'admin', 1, CAST(0x0000A1CA017873BA AS DateTime), 1, N'基础模组', N'系统出错日志', N'S01M01', N'/Manager/Module/FrameWork/SystemMaintenance/SystemErrorLog/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (275, N'admin', 1, CAST(0x0000A1CA017873CE AS DateTime), 1, N'基础模组', N'系统出错日志', N'S01M01', N'/Manager/Module/FrameWork/SystemMaintenance/SystemErrorLog/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (276, N'admin', 1, CAST(0x0000A1CA01787AC2 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (277, N'admin', 1, CAST(0x0000A1CA017E6049 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (278, N'admin', 1, CAST(0x0000A1CA0180CDCD AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (279, N'admin', 1, CAST(0x0000A1CA0181BDB6 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (280, N'admin', 1, CAST(0x0000A1CA01823E88 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (281, N'admin', 1, CAST(0x0000A1CB000F7DBD AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (282, N'admin', 1, CAST(0x0000A1CB000F7E70 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (283, N'admin', 1, CAST(0x0000A1CB000F8750 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (287, N'admin', 1, CAST(0x0000A1CB0029594B AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (288, N'admin', 1, CAST(0x0000A1CB002979DD AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (289, N'admin', 1, CAST(0x0000A1CB0029996D AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (290, N'admin', 1, CAST(0x0000A1CB0029A820 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (291, N'admin', 1, CAST(0x0000A1CB002A02FF AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (292, N'admin', 1, CAST(0x0000A1CB002A1F04 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (293, N'admin', 1, CAST(0x0000A1CB002A6274 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (294, N'admin', 1, CAST(0x0000A1CB002AE77E AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (295, N'admin', 1, CAST(0x0000A1CB002BC144 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (296, N'admin', 1, CAST(0x0000A1CB002E5DB3 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (299, N'admin', 1, CAST(0x0000A1CB002F9D68 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (300, N'admin', 1, CAST(0x0000A1CB00302A83 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (301, N'admin', 1, CAST(0x0000A1CB003291DA AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (305, N'admin', 1, CAST(0x0000A1CB003B4007 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (306, N'admin', 1, CAST(0x0000A1CB003B59DA AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (308, N'admin', 1, CAST(0x0000A1CB00407A3F AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (313, N'admin', 1, CAST(0x0000A1CB004244D8 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (314, N'admin', 1, CAST(0x0000A1CB0042EC94 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (315, N'admin', 1, CAST(0x0000A1CB004328CC AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
GO
print 'Processed 300 total records'
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (316, N'admin', 1, CAST(0x0000A1CB00439524 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (320, N'admin', 1, CAST(0x0000A1CB0045DEB6 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (324, N'admin', 1, CAST(0x0000A1CB00C66271 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (325, N'admin', 1, CAST(0x0000A1CB00C8E23D AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (326, N'admin', 1, CAST(0x0000A1CB00CAC5C5 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (329, N'admin', 1, CAST(0x0000A1CB00CF9928 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (284, N'admin', 1, CAST(0x0000A1CB0024467E AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (285, N'admin', 1, CAST(0x0000A1CB0024BA6F AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (286, N'admin', 1, CAST(0x0000A1CB0024DC58 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (297, N'admin', 1, CAST(0x0000A1CB002EE9E9 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (298, N'admin', 1, CAST(0x0000A1CB002F3F2A AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (302, N'admin', 1, CAST(0x0000A1CB00383D21 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (303, N'admin', 1, CAST(0x0000A1CB00385326 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (304, N'admin', 1, CAST(0x0000A1CB003A7719 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (307, N'admin', 1, CAST(0x0000A1CB003F45EB AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (309, N'admin', 1, CAST(0x0000A1CB00411286 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (310, N'admin', 1, CAST(0x0000A1CB0041614F AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (311, N'admin', 1, CAST(0x0000A1CB0041810B AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (312, N'admin', 1, CAST(0x0000A1CB0041D96E AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (317, N'admin', 1, CAST(0x0000A1CB00440888 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (318, N'admin', 1, CAST(0x0000A1CB00442056 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (319, N'admin', 1, CAST(0x0000A1CB00449E4E AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (321, N'admin', 1, CAST(0x0000A1CB00475E89 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (322, N'admin', 1, CAST(0x0000A1CB004797C0 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (323, N'admin', 1, CAST(0x0000A1CB0048472B AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (327, N'admin', 1, CAST(0x0000A1CB00CED17E AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (332, N'admin', 1, CAST(0x0000A1CB00E74644 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (333, N'admin', 1, CAST(0x0000A1CB00E746AF AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (334, N'admin', 1, CAST(0x0000A1CB0101380E AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (347, N'', 0, CAST(0x0000A1CB0108B177 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'用户名/密码(admin/aemin)错误！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (348, N'', 0, CAST(0x0000A1CB0108BDB4 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013/5/27 15:46:36),从(127.0.0.1)IP登陆在本系统.在线时间:13.98分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (349, N'admin', 1, CAST(0x0000A1CB0108D39D AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=6423&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (350, N'admin', 1, CAST(0x0000A1CB0108D3C3 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=6423&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (351, N'admin', 1, CAST(0x0000A1CB0109B410 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (328, N'admin', 1, CAST(0x0000A1CB00CF51B3 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'修改健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (330, N'admin', 1, CAST(0x0000A1CB00D2451D AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'查看健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (331, N'admin', 1, CAST(0x0000A1CB00D4E79F AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'查看健康档案ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (335, N'', 0, CAST(0x0000A1CB0102B671 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013/5/27 15:36:30),从(127.0.0.1)IP登陆在本系统.在线时间:5.12分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (336, N'', 0, CAST(0x0000A1CB0102BFE7 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013/5/27 15:36:30),从(127.0.0.1)IP登陆在本系统.在线时间:5.12分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (337, N'admin', 1, CAST(0x0000A1CB0102C177 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=8757&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (338, N'admin', 1, CAST(0x0000A1CB0102C190 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=8757&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (339, N'', 0, CAST(0x0000A1CB01037979 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013/5/27 15:42:06),从(127.0.0.1)IP登陆在本系统.在线时间:1.68分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (340, N'admin', 1, CAST(0x0000A1CB01037BAF AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=5610&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (341, N'admin', 1, CAST(0x0000A1CB01037BB4 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=5610&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (342, N'admin', 1, CAST(0x0000A1CB0103F5A8 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (343, N'admin', 1, CAST(0x0000A1CB0103F5B2 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (344, N'', 0, CAST(0x0000A1CB0103FC18 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013/5/27 15:44:44),从(127.0.0.1)IP登陆在本系统.在线时间:0.79分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (345, N'admin', 1, CAST(0x0000A1CB0103FE0F AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=6040&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (346, N'admin', 1, CAST(0x0000A1CB0103FE11 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=6040&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (352, N'admin', 1, CAST(0x0000A1CB0109B42D AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (353, N'', 0, CAST(0x0000A1CB010B2F26 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013/5/27 16:04:12),从(127.0.0.1)IP登陆在本系统.在线时间:7.47分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (354, N'admin', 1, CAST(0x0000A1CB010B30F1 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=3810&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (355, N'admin', 1, CAST(0x0000A1CB010B3110 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=3810&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (356, N'admin', 1, CAST(0x0000A1CB010CC5A1 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (357, N'admin', 1, CAST(0x0000A1CB010CC5AF AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (358, N'', 0, CAST(0x0000A1CB012A182D AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'您的用户名(admin)已经于(2013/5/27 16:12:48),从(127.0.0.1)IP登陆在本系统.在线时间:110.93分.')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (359, N'admin', 1, CAST(0x0000A1CB012A1A12 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=2662&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'强制帐号admin下线成功！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (360, N'admin', 1, CAST(0x0000A1CB012A1A35 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?CMD=OutOnline&OPCode=2662&U_LoginName=admin&U_Password=admin&SessionID=admin', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (361, N'admin', 1, CAST(0x0000A1CC00D0223F AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (362, N'admin', 1, CAST(0x0000A1CC013D9699 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (363, N'admin', 1, CAST(0x0000A1CC013D971E AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (364, N'admin', 1, CAST(0x0000A1CC013DA12D AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (369, N'admin', 1, CAST(0x0000A1CC01463FBF AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/ConsultationManager.aspx?CMD=New&UserID=7', 1, N'127.0.0.1', N'增加会诊记录ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (373, N'admin', 1, CAST(0x0000A1CD00016432 AS DateTime), 1, N'基础模组', N'系统出错日志', N'S01M01', N'/Manager/Module/FrameWork/SystemMaintenance/SystemErrorLog/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (374, N'admin', 1, CAST(0x0000A1CD00016469 AS DateTime), 1, N'基础模组', N'系统出错日志', N'S01M01', N'/Manager/Module/FrameWork/SystemMaintenance/SystemErrorLog/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (375, N'admin', 1, CAST(0x0000A1CE00A2F498 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (376, N'admin', 1, CAST(0x0000A1CE00B48A63 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (377, N'admin', 1, CAST(0x0000A1CE00B48A66 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (378, N'admin', 1, CAST(0x0000A1CE00B48EFA AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (379, N'admin', 1, CAST(0x0000A1CE0115F4FD AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (380, N'admin', 1, CAST(0x0000A1CE0115F5F4 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (381, N'admin', 1, CAST(0x0000A1CE0115FF96 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (382, N'admin', 1, CAST(0x0000A1CE013DBB07 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/ResponsibleDoctors/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (383, N'admin', 1, CAST(0x0000A1CE013DBB22 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/ResponsibleDoctors/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (384, N'admin', 1, CAST(0x0000A1CE013DC081 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (385, N'admin', 1, CAST(0x0000A1CE013E9132 AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=45&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(45)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (386, N'admin', 1, CAST(0x0000A1CE013F45BF AS DateTime), 1, N'基础模组', N'应用模块管理', N'S00M07', N'/Manager/Module/FrameWork/SystemApp/ModuleManager/ModuleManager.aspx?CMD=Edit&ModuleID=45&S_ID=1', 1, N'127.0.0.1', N'增加/修改模块ID(45)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (387, N'admin', 1, CAST(0x0000A1CE0158D4F0 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (388, N'admin', 1, CAST(0x0000A1CE0158D4F7 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (389, N'admin', 1, CAST(0x0000A1CE0158DFC7 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (390, N'admin', 1, CAST(0x0000A1CE01595ED6 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/ResponsibleDoctors/InfoManager.aspx?UserID=7&CMD=Edit', 1, N'127.0.0.1', N'更改责任医生ID(7)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (391, N'admin', 1, CAST(0x0000A1D10139649E AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (392, N'admin', 1, CAST(0x0000A1D201209691 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (393, N'admin', 1, CAST(0x0000A1D40009D704 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (394, N'admin', 1, CAST(0x0000A1D40015F9DA AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthEducation/Activity/InfoManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加健康教育活动ID(0)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (396, N'admin', 1, CAST(0x0000A1D400FFD891 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (397, N'admin', 1, CAST(0x0000A1D401085BAE AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (398, N'admin', 1, CAST(0x0000A1D401085BB5 AS DateTime), 0, N'', N'', N'', N'/Manager/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (399, N'admin', 1, CAST(0x0000A1D401086319 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (400, N'admin', 1, CAST(0x0000A1D40123DF5C AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/FollowUp/InfoManager.aspx?CMD=New', 1, N'127.0.0.1', N'增加特定随访工作计划ID(3)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (402, N'admin', 1, CAST(0x0000A1D40124196D AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/FollowUp/InfoManager.aspx?FollowUpID=3&CMD=Edit', 1, N'127.0.0.1', N'修改特定随访工作计划ID(3)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (403, N'admin', 1, CAST(0x0000A1D4017392F5 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/AnnouncementReporting/Announcement/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (404, N'admin', 1, CAST(0x0000A1D401739379 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/AnnouncementReporting/Announcement/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (405, N'admin', 1, CAST(0x0000A1D401739B43 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (406, N'admin', 1, CAST(0x0000A1D6000E2953 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (365, N'admin', 1, CAST(0x0000A1CC014005AB AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/ConsultationManager.aspx?ConsultationID=1&CMD=Edit', 1, N'127.0.0.1', N'修改会诊记录ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (366, N'admin', 1, CAST(0x0000A1CC0140FFF2 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/ConsultationManager.aspx?ConsultationID=1&CMD=Edit', 1, N'127.0.0.1', N'修改会诊记录ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (367, N'admin', 1, CAST(0x0000A1CC01430551 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/ConsultationManager.aspx?ConsultationID=1&CMD=Edit', 1, N'127.0.0.1', N'修改会诊记录ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (368, N'admin', 1, CAST(0x0000A1CC0143442C AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/ConsultationManager.aspx?ConsultationID=1&CMD=Edit', 1, N'127.0.0.1', N'修改会诊记录ID(1)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (370, N'admin', 1, CAST(0x0000A1CC01681519 AS DateTime), 0, N'', N'', N'', N'/Manager/Module/FrameWork/CommonModule/SelectGroup.aspx?4781551', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (371, N'admin', 1, CAST(0x0000A1CC016815A5 AS DateTime), 0, N'', N'', N'', N'/Manager/Module/FrameWork/CommonModule/SelectGroup.aspx?4781551', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
GO
print 'Processed 400 total records'
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (372, N'admin', 1, CAST(0x0000A1CC0168226B AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (395, N'admin', 1, CAST(0x0000A1D4001714E3 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthEducation/Activity/InfoManager.aspx?ActivityID=6&CMD=Edit', 1, N'127.0.0.1', N'修改健康教育活动ID(6)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (401, N'admin', 1, CAST(0x0000A1D40124101D AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/FollowUp/InfoManager.aspx?FollowUpID=3&CMD=Edit', 1, N'127.0.0.1', N'修改特定随访工作计划ID(3)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (407, N'admin', 1, CAST(0x0000A1D60099082B AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (408, N'admin', 1, CAST(0x0000A1D600AD5347 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (409, N'admin', 1, CAST(0x0000A1D600AD536B AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (410, N'admin', 1, CAST(0x0000A1D600AD5917 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (411, N'admin', 1, CAST(0x0000A1D6011E0701 AS DateTime), 0, N'', N'', N'', N'/Manager/Login.aspx?ReturnUrl=%2fManager%2fdefault.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (412, N'admin', 1, CAST(0x0000A1D60125A476 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/InfoManager.aspx?InfoID=2&CMD=Edit', 1, N'127.0.0.1', N'修改信息ID(2)成功!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (413, N'admin', 1, CAST(0x0000A1D6014E8E07 AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (415, N'admin', 1, CAST(0x0000A1D6014E93E2 AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (416, N'admin', 1, CAST(0x0000A1D6014EB58C AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/default.aspx', 2, N'127.0.0.1', N'ctl00$PageBody$I_FindDate字段值：2013-6-71数据类型必需为日期型!')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (417, N'admin', 1, CAST(0x0000A1D60162D180 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/AnnouncementReporting/Announcement/default.aspx', 2, N'127.0.0.1', N'用户退出')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (418, N'admin', 1, CAST(0x0000A1D60162D186 AS DateTime), 1, N'基础模组', N'个人健康档案管理', N'S02M00', N'/Manager/Module/FrameWork/AnnouncementReporting/Announcement/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (419, N'admin', 1, CAST(0x0000A1D60162D6CA AS DateTime), 0, N'', N'', N'', N'/Manager/login.aspx', 2, N'127.0.0.1', N'欢迎您admin，成功登入。您的IP为：127.0.0.1！')
INSERT [dbo].[sys_Event] ([EventID], [E_U_LoginName], [E_UserID], [E_DateTime], [E_ApplicationID], [E_A_AppName], [E_M_Name], [E_M_PageCode], [E_From], [E_Type], [E_IP], [E_Record]) VALUES (414, N'admin', 1, CAST(0x0000A1D6014E8E5C AS DateTime), 1, N'基础模组', N'信息登记', N'S06M00', N'/Manager/Module/FrameWork/HealthSupervision/Info/default.aspx', 2, N'127.0.0.1', N'您与系统的连接已经超时，请重新登陆！')
SET IDENTITY_INSERT [dbo].[sys_Event] OFF
/****** Object:  Table [dbo].[sys_Field]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Field]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Field](
	[FieldID] [int] IDENTITY(1,1) NOT NULL,
	[F_Key] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[F_CName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[F_Remark] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_Sys_Field] PRIMARY KEY NONCLUSTERED 
(
	[FieldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Field', N'COLUMN',N'FieldID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用字段ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field', @level2type=N'COLUMN',@level2name=N'FieldID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Field', N'COLUMN',N'F_Key'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用字段关键字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field', @level2type=N'COLUMN',@level2name=N'F_Key'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Field', N'COLUMN',N'F_CName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用字段中文说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field', @level2type=N'COLUMN',@level2name=N'F_CName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Field', N'COLUMN',N'F_Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field', @level2type=N'COLUMN',@level2name=N'F_Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Field', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统应用字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field'
GO
SET IDENTITY_INSERT [dbo].[sys_Field] ON
INSERT [dbo].[sys_Field] ([FieldID], [F_Key], [F_CName], [F_Remark]) VALUES (2, N'Title', N'职称', N'用户职称列表')
SET IDENTITY_INSERT [dbo].[sys_Field] OFF
/****** Object:  Table [dbo].[sys_FieldValue]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_FieldValue]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_FieldValue](
	[ValueID] [int] IDENTITY(1,1) NOT NULL,
	[V_F_Key] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[V_Text] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[V_Code] [varchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[V_ShowOrder] [int] NOT NULL,
 CONSTRAINT [PK_Sys_FieldValue] PRIMARY KEY NONCLUSTERED 
(
	[ValueID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_FieldValue', N'COLUMN',N'ValueID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'索引ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'ValueID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_FieldValue', N'COLUMN',N'V_F_Key'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'与sys_Field表中F_Key字段关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'V_F_Key'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_FieldValue', N'COLUMN',N'V_Text'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'中文说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'V_Text'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_FieldValue', N'COLUMN',N'V_Code'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'V_Code'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_FieldValue', N'COLUMN',N'V_ShowOrder'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'同级显示顺序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'V_ShowOrder'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_FieldValue', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用字段值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue'
GO
SET IDENTITY_INSERT [dbo].[sys_FieldValue] ON
INSERT [dbo].[sys_FieldValue] ([ValueID], [V_F_Key], [V_Text], [V_Code], [V_ShowOrder]) VALUES (5, N'title', N'普通员工', NULL, 5)
INSERT [dbo].[sys_FieldValue] ([ValueID], [V_F_Key], [V_Text], [V_Code], [V_ShowOrder]) VALUES (16, N'Title', N'职业员工', NULL, 3)
INSERT [dbo].[sys_FieldValue] ([ValueID], [V_F_Key], [V_Text], [V_Code], [V_ShowOrder]) VALUES (17, N'Title', N'高级程序员', NULL, 2)
INSERT [dbo].[sys_FieldValue] ([ValueID], [V_F_Key], [V_Text], [V_Code], [V_ShowOrder]) VALUES (18, N'Title', N'试用期员工', NULL, 4)
INSERT [dbo].[sys_FieldValue] ([ValueID], [V_F_Key], [V_Text], [V_Code], [V_ShowOrder]) VALUES (19, N'Title', N'经理员工', NULL, 1)
SET IDENTITY_INSERT [dbo].[sys_FieldValue] OFF
/****** Object:  Table [dbo].[sys_Group]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Group]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Group](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[G_CName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[G_ParentID] [int] NOT NULL,
	[G_ShowOrder] [int] NOT NULL,
	[G_Level] [int] NULL,
	[G_ChildCount] [int] NULL,
	[G_Delete] [tinyint] NULL,
	[G_Type] [tinyint] NULL,
	[G_Code] [varchar](20) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_SYS_GROUP] PRIMARY KEY NONCLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'GroupID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'GroupID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'G_CName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类中文说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_CName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'G_ParentID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上级分类ID0:为最高级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_ParentID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'G_ShowOrder'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'显示顺序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_ShowOrder'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'G_Level'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前分类所在层数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_Level'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'G_ChildCount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当???分类子分类数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_ChildCount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'G_Delete'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除1:是0:否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_Delete'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'G_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门类型，0表示非医院部门，1表示医院部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', N'COLUMN',N'G_Code'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'行政代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_Code'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Group', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group'
GO
SET IDENTITY_INSERT [dbo].[sys_Group] ON
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (1, N'广东省', 0, 1, 1, 1, 0, NULL, NULL)
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (2, N'广州市', 0, 2, 1, 0, 0, 0, N'1223')
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (3, N'茂名市', 1, 1, 2, 5, 0, NULL, NULL)
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (4, N'茂港区', 3, 1, 3, 1, 0, NULL, NULL)
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (5, N'禄段村委会', 10, 1, 5, 0, 0, 0, N'')
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (6, N'高州市', 3, 2, 3, 1, 0, 0, N'111')
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (7, N'化州市', 3, 3, 3, 0, 0, 0, N'123')
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (8, N'茂南区', 3, 4, 3, 0, 0, 0, N'3233')
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (9, N'电白县', 3, 5, 3, 0, 0, 0, N'3323')
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (10, N'羊角镇', 4, 1, 4, 1, 0, 0, N'')
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (11, N'分界镇', 6, 1, 4, 1, 0, 0, N'32')
INSERT [dbo].[sys_Group] ([GroupID], [G_CName], [G_ParentID], [G_ShowOrder], [G_Level], [G_ChildCount], [G_Delete], [G_Type], [G_Code]) VALUES (12, N'分界街居委会', 11, 1, 5, 0, 0, 0, N'232')
SET IDENTITY_INSERT [dbo].[sys_Group] OFF
/****** Object:  Table [dbo].[sys_ModuleExtPermission]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ModuleExtPermission]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_ModuleExtPermission](
	[ExtPermissionID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleID] [int] NOT NULL,
	[PermissionName] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[PermissionValue] [int] NOT NULL,
 CONSTRAINT [PK_SYS_MODULEEXTPERMISSION] PRIMARY KEY NONCLUSTERED 
(
	[ModuleID] ASC,
	[PermissionValue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_ModuleExtPermission', N'COLUMN',N'ExtPermissionID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展权限ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission', @level2type=N'COLUMN',@level2name=N'ExtPermissionID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_ModuleExtPermission', N'COLUMN',N'ModuleID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_ModuleExtPermission', N'COLUMN',N'PermissionName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission', @level2type=N'COLUMN',@level2name=N'PermissionName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_ModuleExtPermission', N'COLUMN',N'PermissionValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission', @level2type=N'COLUMN',@level2name=N'PermissionValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_ModuleExtPermission', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块扩展权限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission'
GO
/****** Object:  Table [dbo].[sys_Module]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Module]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Module](
	[ModuleID] [int] IDENTITY(1,1) NOT NULL,
	[M_ApplicationID] [int] NOT NULL,
	[M_ParentID] [int] NOT NULL,
	[M_PageCode] [varchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[M_CName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[M_Directory] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[M_OrderLevel] [varchar](4) COLLATE Chinese_PRC_CI_AS NULL,
	[M_IsSystem] [tinyint] NULL,
	[M_Close] [tinyint] NULL,
	[M_Icon] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[M_Info] [nvarchar](500) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_Sys_Module] PRIMARY KEY NONCLUSTERED 
(
	[M_PageCode] ASC,
	[M_ApplicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'ModuleID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能模块ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_ApplicationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属应用程序ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_ApplicationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_ParentID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属父级模块ID与ModuleID关联,0为顶级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_ParentID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_PageCode'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块编码Parent为0,则为S00(xx),否则为S00M00(xx)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_PageCode'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_CName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块/栏目名称当ParentID为0为模块名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_CName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_Directory'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块/栏目???录名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_Directory'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_OrderLevel'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前所在排序级别支持双层99级菜单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_OrderLevel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_IsSystem'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否为系统模块1:是0:否如为系统则无法修改' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_IsSystem'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_Close'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否关闭1:是0:否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_Close'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_Icon'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块Icon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_Icon'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', N'COLUMN',N'M_Info'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_Info'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Module', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能模块' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module'
GO
SET IDENTITY_INSERT [dbo].[sys_Module] ON
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (1, 1, 0, N'S00', N'系统管理', NULL, N'0000', 1, 0, NULL, NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (2, 1, 1, N'S00M00', N'应用列表管理', N'Module/FrameWork/SystemApp/AppManager/list.aspx', N'0001', 1, 0, N'~/manager/images/icon/applist.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (4, 1, 1, N'S00M01', N'部门管理', N'Module/FrameWork/SystemApp/GroupManager/Frame.aspx', N'0003', 1, 0, N'~/manager/images/icon/grouplist.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (5, 1, 1, N'S00M02', N'角色管理', N'Module/FrameWork/SystemApp/RoleManager/RoleList.aspx', N'0004', 1, 0, N'~/manager/images/icon/rule.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (6, 1, 1, N'S00M03', N'用户管理', N'Module/FrameWork/SystemApp/UserManager/default.aspx', N'0005', 1, 0, N'~/manager/images/icon/user.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (7, 1, 1, N'S00M04', N'应用字段设定', N'Module/FrameWork/SystemApp/FieldManager/default.aspx', N'0006', 1, 0, N'~/manager/images/icon/FieldManager.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (8, 1, 1, N'S00M05', N'事件日志管理', N'Module/FrameWork/SystemApp/EventManager/default.aspx', N'0007', 1, 0, N'~/manager/images/icon/log.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (9, 1, 1, N'S00M06', N'在线用户列表', N'Module/FrameWork/SystemApp/OnlineUserManager/default.aspx', N'0008', 1, 0, N'~/manager/images/icon/online.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (26, 1, 1, N'S00M07', N'应用模块管理', N'Module/FrameWork/SystemApp/ModuleManager/list.aspx', N'0002', 1, 0, N'~/manager/images/icon/module.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (27, 1, 0, N'S01', N'系统维护', N'', N'0100', 1, 0, NULL, NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (28, 1, 27, N'S01M00', N'系统运行状态', N'Module/FrameWork/SystemMaintenance/SystemState/default.aspx', N'0101', 1, 0, N'~/manager/images/icon/status.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (29, 1, 27, N'S01M01', N'系统出错日志', N'Module/FrameWork/SystemMaintenance/SystemErrorLog/default.aspx', N'0102', 1, 0, N'~/manager/images/icon/bug.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (30, 1, 27, N'S01M02', N'系统环境配置', N'Module/FrameWork/SystemMaintenance/SystemConfig/default.aspx', N'0103', 1, 0, N'~/manager/images/icon/config.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (31, 1, 0, N'S02', N'健康档案管理', N'', N'0200', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (32, 1, 31, N'S02M00', N'个人健康档案管理', N'Module/FrameWork/HealthRecords/PersonalRecords/default.aspx', N'0201', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (33, 1, 0, N'S03', N'统计分析', N'', N'0300', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (34, 1, 33, N'S03M00', N'性别统计', N'Module/FrameWork/StatisticalAnalysis/sexStatistical.aspx', N'0301', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (35, 1, 33, N'S03M01', N'年龄统计', N'Module/FrameWork/StatisticalAnalysis/ageStatistical.aspx', N'0302', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (36, 1, 33, N'S03M02', N'付费类型统计', N'Module/FrameWork/StatisticalAnalysis/payTypeStatistical.aspx', N'0303', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (38, 1, 33, N'S03M04', N'疾病人数统计', N'Module/FrameWork/StatisticalAnalysis/diseaseStatistical.aspx', N'0305', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (39, 1, 33, N'S03M05', N'常住类型统计', N'Module/FrameWork/StatisticalAnalysis/UsualTypeStatistical.aspx', N'0306', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (40, 1, 33, N'S03M06', N'年龄段患病统计', N'Module/FrameWork/StatisticalAnalysis/differentAgesPatientsStatistica.aspx', N'0307', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (41, 1, 33, N'S03M07', N'社区建档统计', N'Module/FrameWork/StatisticalAnalysis/CommunityFilingStatistical.aspx', N'0308', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (42, 1, 33, N'S03M08', N'居委会建档统计', N'Module/FrameWork/StatisticalAnalysis/neighborhoodCommitteesStatistical.aspx', N'0309', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (44, 1, 31, N'S02M02', N'居民死亡登记', N'Module/FrameWork/HealthRecords/DeathRegistration/default.aspx', N'0203', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (45, 1, 31, N'S02M03', N'责任医生管理', N'Module/FrameWork/HealthRecords/ResponsibleDoctors/default.aspx', N'0204', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (47, 1, 0, N'S04', N'公告与报告', N'', N'0400', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (48, 1, 47, N'S04M00', N'系统公告', N'Module/FrameWork/AnnouncementReporting/Announcement/default.aspx', N'0401', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (49, 1, 47, N'S04M01', N'迁入迁出档案管理', N'Module/FrameWork/AnnouncementReporting/Reporting/MoveRecords/default.aspx', N'0402', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (50, 1, 47, N'S04M02', N'传染病及突发事件', N'Module/FrameWork/AnnouncementReporting/Reporting/Emergencies/default.aspx', N'0403', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (55, 1, 0, N'S06', N'卫生监督协管', N'', N'0600', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (56, 1, 55, N'S06M00', N'信息登记', N'Module/FrameWork/HealthSupervision/Info/default.aspx', N'0601', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (57, 1, 55, N'S06M01', N'巡查登记', N'Module/FrameWork/HealthSupervision/Inspect/default.aspx', N'0602', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (37, 1, 33, N'S03M03', N'民族类型统计', N'Module/FrameWork/StatisticalAnalysis/nationTypeStatistical.aspx', N'0304', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (43, 1, 31, N'S02M01', N'家庭健康档案管理', N'Module/FrameWork/HealthRecords/FamilyRecords/default.aspx', N'0202', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (46, 1, 31, N'S02M04', N'特定随访工作', N'Module/FrameWork/HealthRecords/FollowUp/default.aspx', N'0205', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (51, 1, 0, N'S05', N'健康教育', N'', N'0500', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (52, 1, 51, N'S05M00', N'健康教育活动', N'Module/FrameWork/HealthEducation/Activity/default.aspx', N'0501', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (53, 1, 51, N'S05M01', N'健康教育处方', N'Module/FrameWork/HealthEducation/Prescription/default.aspx', N'0502', 0, 0, N'~/manager/images/icon/default.gif', NULL)
INSERT [dbo].[sys_Module] ([ModuleID], [M_ApplicationID], [M_ParentID], [M_PageCode], [M_CName], [M_Directory], [M_OrderLevel], [M_IsSystem], [M_Close], [M_Icon], [M_Info]) VALUES (54, 1, 51, N'S05M02', N'下载专区', N'Module/FrameWork/HealthEducation/Document/default.aspx', N'0503', 0, 0, N'~/manager/images/icon/default.gif', NULL)
SET IDENTITY_INSERT [dbo].[sys_Module] OFF
/****** Object:  Table [dbo].[sys_Online]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Online]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Online](
	[OnlineID] [int] IDENTITY(1,1) NOT NULL,
	[O_SessionID] [varchar](24) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[O_UserName] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[O_Ip] [varchar](15) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[O_LoginTime] [datetime] NOT NULL,
	[O_LastTime] [datetime] NOT NULL,
	[O_LastUrl] [nvarchar](500) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_SYS_ONLINE] PRIMARY KEY NONCLUSTERED 
(
	[O_SessionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Online', N'COLUMN',N'OnlineID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'OnlineID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Online', N'COLUMN',N'O_SessionID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户SessionID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_SessionID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Online', N'COLUMN',N'O_UserName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_UserName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Online', N'COLUMN',N'O_Ip'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户IP地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_Ip'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Online', N'COLUMN',N'O_LoginTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登陆时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_LoginTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Online', N'COLUMN',N'O_LastTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后访问时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_LastTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Online', N'COLUMN',N'O_LastUrl'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后请求网站' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_LastUrl'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Online', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'在线用户表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online'
GO
SET IDENTITY_INSERT [dbo].[sys_Online] ON
INSERT [dbo].[sys_Online] ([OnlineID], [O_SessionID], [O_UserName], [O_Ip], [O_LoginTime], [O_LastTime], [O_LastUrl]) VALUES (88, N'hvt0knjgibtrk545vr2o5v45', N'admin', N'127.0.0.1', CAST(0x0000A1D60162D6C7 AS DateTime), CAST(0x0000A1D6016352DD AS DateTime), N'/Manager/Module/FrameWork/AnnouncementReporting/Announcement/InfoManager.aspx?CMD=New')
SET IDENTITY_INSERT [dbo].[sys_Online] OFF
/****** Object:  Table [dbo].[sys_RoleApplication]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RoleApplication]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_RoleApplication](
	[A_RoleID] [int] NOT NULL,
	[A_ApplicationID] [int] NOT NULL,
 CONSTRAINT [PK_SYS_ROLEAPPLICATION] PRIMARY KEY NONCLUSTERED 
(
	[A_RoleID] ASC,
	[A_ApplicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RoleApplication', N'COLUMN',N'A_RoleID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID与sys_Roles中RoleID相关' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RoleApplication', @level2type=N'COLUMN',@level2name=N'A_RoleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RoleApplication', N'COLUMN',N'A_ApplicationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用ID与sys_Applications中Appl' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RoleApplication', @level2type=N'COLUMN',@level2name=N'A_ApplicationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RoleApplication', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色应用表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RoleApplication'
GO
INSERT [dbo].[sys_RoleApplication] ([A_RoleID], [A_ApplicationID]) VALUES (1, 1)
/****** Object:  Table [dbo].[sys_RolePermission]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_RolePermission](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[P_RoleID] [int] NOT NULL,
	[P_ApplicationID] [int] NOT NULL,
	[P_PageCode] [varchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[P_Value] [int] NULL,
 CONSTRAINT [PK_sys_RolePermission] PRIMARY KEY NONCLUSTERED 
(
	[P_RoleID] ASC,
	[P_ApplicationID] ASC,
	[P_PageCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RolePermission', N'COLUMN',N'PermissionID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色应用权限自动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'PermissionID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RolePermission', N'COLUMN',N'P_RoleID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID与sys_Roles表中RoleID相' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'P_RoleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RolePermission', N'COLUMN',N'P_ApplicationID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色所属应用ID与sys_Applicatio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'P_ApplicationID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RolePermission', N'COLUMN',N'P_PageCode'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色应用中页面权限代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'P_PageCode'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RolePermission', N'COLUMN',N'P_Value'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'P_Value'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_RolePermission', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色应用权限表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission'
GO
SET IDENTITY_INSERT [dbo].[sys_RolePermission] ON
INSERT [dbo].[sys_RolePermission] ([PermissionID], [P_RoleID], [P_ApplicationID], [P_PageCode], [P_Value]) VALUES (4, 1, 1, N'S02M00', 2)
INSERT [dbo].[sys_RolePermission] ([PermissionID], [P_RoleID], [P_ApplicationID], [P_PageCode], [P_Value]) VALUES (5, 1, 1, N'S06M00', 6)
SET IDENTITY_INSERT [dbo].[sys_RolePermission] OFF
/****** Object:  Table [dbo].[sys_Roles]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Roles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[R_UserID] [int] NOT NULL,
	[R_RoleName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[R_Description] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_sys_Roles] PRIMARY KEY NONCLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Roles', N'COLUMN',N'RoleID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID自动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Roles', N'COLUMN',N'R_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角角所属用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles', @level2type=N'COLUMN',@level2name=N'R_UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Roles', N'COLUMN',N'R_RoleName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles', @level2type=N'COLUMN',@level2name=N'R_RoleName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Roles', N'COLUMN',N'R_Description'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色介绍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles', @level2type=N'COLUMN',@level2name=N'R_Description'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_Roles', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles'
GO
SET IDENTITY_INSERT [dbo].[sys_Roles] ON
INSERT [dbo].[sys_Roles] ([RoleID], [R_UserID], [R_RoleName], [R_Description]) VALUES (1, 1, N'普通居民', N'普通居民')
INSERT [dbo].[sys_Roles] ([RoleID], [R_UserID], [R_RoleName], [R_Description]) VALUES (2, 1, N'医生', N'医生')
INSERT [dbo].[sys_Roles] ([RoleID], [R_UserID], [R_RoleName], [R_Description]) VALUES (3, 1, N'医院管理员', N'医院管理员')
INSERT [dbo].[sys_Roles] ([RoleID], [R_UserID], [R_RoleName], [R_Description]) VALUES (4, 1, N'居(村)委会管理员', N'居(村)委会管理员')
INSERT [dbo].[sys_Roles] ([RoleID], [R_UserID], [R_RoleName], [R_Description]) VALUES (5, 1, N'镇管理员', N'镇管理员')
INSERT [dbo].[sys_Roles] ([RoleID], [R_UserID], [R_RoleName], [R_Description]) VALUES (6, 1, N'县管理员', N'县管理员')
INSERT [dbo].[sys_Roles] ([RoleID], [R_UserID], [R_RoleName], [R_Description]) VALUES (7, 1, N'市管理员', N'市管理员')
INSERT [dbo].[sys_Roles] ([RoleID], [R_UserID], [R_RoleName], [R_Description]) VALUES (8, 1, N'省管理员', N'省管理员')
SET IDENTITY_INSERT [dbo].[sys_Roles] OFF
/****** Object:  Table [dbo].[sys_SystemInfo]    Script Date: 06/08/2013 10:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_SystemInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_SystemInfo](
	[SystemID] [int] IDENTITY(1,1) NOT NULL,
	[S_Name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[S_Version] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[S_SystemConfigData] [image] NULL,
	[S_Licensed] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_SYS_SYSTEMINFO] PRIMARY KEY NONCLUSTERED 
(
	[SystemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_SystemInfo', N'COLUMN',N'SystemID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'SystemID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_SystemInfo', N'COLUMN',N'S_Name'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'S_Name'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_SystemInfo', N'COLUMN',N'S_Version'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'版本号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'S_Version'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_SystemInfo', N'COLUMN',N'S_SystemConfigData'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统配置信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'S_SystemConfigData'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_SystemInfo', N'COLUMN',N'S_Licensed'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序列号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'S_Licensed'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_SystemInfo', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo'
GO
SET IDENTITY_INSERT [dbo].[sys_SystemInfo] ON
INSERT [dbo].[sys_SystemInfo] ([SystemID], [S_Name], [S_Version], [S_SystemConfigData], [S_Licensed]) VALUES (1, N'Supesoft权限管理系统(FrameWork)', N'1.0.8', 0x0001000000FFFFFFFF01000000000000000C02000000404672616D65576F726B2C2056657273696F6E3D312E302E392E302C2043756C747572653D6E65757472616C2C205075626C69634B6579546F6B656E3D6E756C6C0501000000284672616D65576F726B2E436F6D706F6E656E74732E7379735F436F6E666967446174615461626C65100000000E5F435F5570496D674865696768740D5F435F5570496D6757696474680D5F435F55706C6F6164506174680F5F435F55706C6F616453697A654B62105F435F55706C6F616446696C654578740D5F435F526571756573744C6F670C5F435F49504C6F6F6B55726C1A5F435F4C6F67696E4572726F7244697361626C654D696E757465135F435F4C6F67696E4572726F724D61784E756D0B5F435F48747470475A69700E5F435F436865636B5570646174650C5F435F44697361626C654970105F435F44697361626C6549704C6973740E5F435F456E61626C655F4C6461700C5F435F4C6461705F506174680E5F435F4C6461705F446F6D61696E0000010001000100000000010300010108080801080801017F53797374656D2E436F6C6C656374696F6E732E47656E657269632E4C69737460315B5B53797374656D2E537472696E672C206D73636F726C69622C2056657273696F6E3D342E302E302E302C2043756C747572653D6E65757472616C2C205075626C69634B6579546F6B656E3D623737613563353631393334653038395D5D010200000078000000B40000000603000000102F4D616E616765722F5075626C69632F0004000006040000001F7A69702C7261722C646F632C6A70672C706E672C6769662C626D702C7377660006050000001B687474703A2F2F7777772E7961686F6F2E636E2F733F703D7B307D3C0000001400000000010606000000000907000000000608000000254C4441503A2F2F7878782E636F6D2E636E2F44433D7878782C44433D636F6D2C44433D636E06090000000A7878782E636F6D2E636E04070000007F53797374656D2E436F6C6C656374696F6E732E47656E657269632E4C69737460315B5B53797374656D2E537472696E672C206D73636F726C69622C2056657273696F6E3D342E302E302E302C2043756C747572653D6E65757472616C2C205075626C69634B6579546F6B656E3D623737613563353631393334653038395D5D03000000065F6974656D73055F73697A65085F76657273696F6E0600000808090A0000000000000000000000110A000000000000000B, N'')
SET IDENTITY_INSERT [dbo].[sys_SystemInfo] OFF
/****** Object:  Table [dbo].[sys_User]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[U_LoginName] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[U_Password] [varchar](32) COLLATE Chinese_PRC_CI_AS NULL,
	[U_CName] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[U_EName] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[U_GroupID] [int] NULL,
	[U_Email] [varchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[U_Type] [tinyint] NOT NULL,
	[U_Status] [tinyint] NOT NULL,
	[U_Licence] [varchar](30) COLLATE Chinese_PRC_CI_AS NULL,
	[U_Mac] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[U_Remark] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[U_IDCard] [varchar](30) COLLATE Chinese_PRC_CI_AS NULL,
	[U_Sex] [tinyint] NULL,
	[U_BirthDay] [datetime] NULL,
	[U_MobileNo] [varchar](15) COLLATE Chinese_PRC_CI_AS NULL,
	[U_UserNO] [varchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[U_WorkStartDate] [datetime] NULL,
	[U_WorkEndDate] [datetime] NULL,
	[U_CompanyMail] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[U_Title] [int] NULL,
	[U_Extension] [varchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[U_HomeTel] [varchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[U_PhotoUrl] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[U_DateTime] [datetime] NULL,
	[U_LastIP] [varchar](15) COLLATE Chinese_PRC_CI_AS NULL,
	[U_LastDateTime] [datetime] NULL,
	[U_ExtendField] [ntext] COLLATE Chinese_PRC_CI_AS NULL,
	[U_LoginType] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[U_HospitalGroupID] [int] NULL,
 CONSTRAINT [PK_Sys_User] PRIMARY KEY NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_LoginName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登陆名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_LoginName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Password'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码md5加密字符' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Password'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_CName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'中文姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_CName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_EName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'英文名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_EName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_GroupID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门ID号与sys_Group表中GroupID关联，这里是选择所在居委会' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_GroupID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Email'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电子邮件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Email'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Type'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户类型0:超级用户1:普通用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前状态0:正常 1:禁止登陆 2:删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Licence'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户序列号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Licence'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Mac'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'锁定机器硬件地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Mac'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_IDCard'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_IDCard'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Sex'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别1:男0:女' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Sex'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_BirthDay'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出生日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_BirthDay'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_MobileNo'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_MobileNo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_UserNO'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_UserNO'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_WorkStartDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'到职日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_WorkStartDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_WorkEndDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'离职日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_WorkEndDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_CompanyMail'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公司邮件地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_CompanyMail'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职称与应用字段关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_Extension'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Extension'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_HomeTel'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家中电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_HomeTel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_PhotoUrl'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户照片网址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_PhotoUrl'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_DateTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_DateTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_LastIP'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后访问IP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_LastIP'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_LastDateTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后访问时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_LastDateTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_ExtendField'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_ExtendField'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_LoginType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登入类型(为空系统认证,其它值为其它认证)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_LoginType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', N'COLUMN',N'U_HospitalGroupID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医院部门ID号与sys_Group表中GroupID关联，这里是选择所在医院部门，默认为0，即表示该用户是非医院工作人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_HospitalGroupID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_User', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User'
GO
SET IDENTITY_INSERT [dbo].[sys_User] ON
INSERT [dbo].[sys_User] ([UserID], [U_LoginName], [U_Password], [U_CName], [U_EName], [U_GroupID], [U_Email], [U_Type], [U_Status], [U_Licence], [U_Mac], [U_Remark], [U_IDCard], [U_Sex], [U_BirthDay], [U_MobileNo], [U_UserNO], [U_WorkStartDate], [U_WorkEndDate], [U_CompanyMail], [U_Title], [U_Extension], [U_HomeTel], [U_PhotoUrl], [U_DateTime], [U_LastIP], [U_LastDateTime], [U_ExtendField], [U_LoginType], [U_HospitalGroupID]) VALUES (1, N'admin', N'21232F297A57A5A743894A0E4A801FC3', N'管理员', N'', 1, N'', 0, 0, N'', N'', N'', N'', 0, CAST(0x0000995600000000 AS DateTime), N'', N'', CAST(0x0000995600000000 AS DateTime), CAST(0x00009956010011D3 AS DateTime), N'', 17, N'', N'', N'', CAST(0x00009956010011D3 AS DateTime), N'127.0.0.1', CAST(0x0000A1D6009D911C AS DateTime), N'2,10,default', NULL, NULL)
INSERT [dbo].[sys_User] ([UserID], [U_LoginName], [U_Password], [U_CName], [U_EName], [U_GroupID], [U_Email], [U_Type], [U_Status], [U_Licence], [U_Mac], [U_Remark], [U_IDCard], [U_Sex], [U_BirthDay], [U_MobileNo], [U_UserNO], [U_WorkStartDate], [U_WorkEndDate], [U_CompanyMail], [U_Title], [U_Extension], [U_HomeTel], [U_PhotoUrl], [U_DateTime], [U_LastIP], [U_LastDateTime], [U_ExtendField], [U_LoginType], [U_HospitalGroupID]) VALUES (2, N'test', N'E10ADC3949BA59ABBE56E057F20F883E', N'测试1', N'', 5, N'', 1, 0, N'', N'', N'', N'440923', 0, CAST(0x0000A1AB00000000 AS DateTime), N'', N'', NULL, NULL, N'', 0, N'', N'', N'20130425095551843e.jpg', CAST(0x0000A1A9016B1930 AS DateTime), N'127.0.0.1', CAST(0x0000A1C400A50294 AS DateTime), N'2,10,default', NULL, NULL)
INSERT [dbo].[sys_User] ([UserID], [U_LoginName], [U_Password], [U_CName], [U_EName], [U_GroupID], [U_Email], [U_Type], [U_Status], [U_Licence], [U_Mac], [U_Remark], [U_IDCard], [U_Sex], [U_BirthDay], [U_MobileNo], [U_UserNO], [U_WorkStartDate], [U_WorkEndDate], [U_CompanyMail], [U_Title], [U_Extension], [U_HomeTel], [U_PhotoUrl], [U_DateTime], [U_LastIP], [U_LastDateTime], [U_ExtendField], [U_LoginType], [U_HospitalGroupID]) VALUES (3, N'test2', N'21232F297A57A5A743894A0E4A801FC3', N'测试2', N'', 5, N'', 1, 0, N'', N'', N'', N'434354', 0, NULL, N'13424', N'', NULL, NULL, N'', 0, N'', N'', N'', CAST(0x0000A1BD018842F7 AS DateTime), N'127.0.0.1', CAST(0x0000A1BD018842F6 AS DateTime), N'', NULL, 0)
INSERT [dbo].[sys_User] ([UserID], [U_LoginName], [U_Password], [U_CName], [U_EName], [U_GroupID], [U_Email], [U_Type], [U_Status], [U_Licence], [U_Mac], [U_Remark], [U_IDCard], [U_Sex], [U_BirthDay], [U_MobileNo], [U_UserNO], [U_WorkStartDate], [U_WorkEndDate], [U_CompanyMail], [U_Title], [U_Extension], [U_HomeTel], [U_PhotoUrl], [U_DateTime], [U_LastIP], [U_LastDateTime], [U_ExtendField], [U_LoginType], [U_HospitalGroupID]) VALUES (7, N'test3', N'21232F297A57A5A743894A0E4A801FC3', N'测试3', N'', 5, N'', 1, 0, N'', N'', N'', N'440923199006294115', 1, CAST(0x0000811B00000000 AS DateTime), N'13243', N'', CAST(0x0000A1C0001D6F28 AS DateTime), CAST(0x0000A1C0001D6F28 AS DateTime), N'', 0, N'', N'', N'', CAST(0x0000A1C0001D6F28 AS DateTime), N'', CAST(0x0000A1C0001D6F28 AS DateTime), N'', N'', 0)
SET IDENTITY_INSERT [dbo].[sys_User] OFF
/****** Object:  Table [dbo].[sys_UserRoles]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserRoles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_UserRoles](
	[R_UserID] [int] NOT NULL,
	[R_RoleID] [int] NOT NULL,
 CONSTRAINT [PK_SYS_USERROLES] PRIMARY KEY NONCLUSTERED 
(
	[R_UserID] ASC,
	[R_RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_UserRoles', N'COLUMN',N'R_UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID与sys_User表中UserID相关' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_UserRoles', @level2type=N'COLUMN',@level2name=N'R_UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_UserRoles', N'COLUMN',N'R_RoleID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户所属角色ID与Sys_Roles关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_UserRoles', @level2type=N'COLUMN',@level2name=N'R_RoleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'sys_UserRoles', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户角色表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_UserRoles'
GO
INSERT [dbo].[sys_UserRoles] ([R_UserID], [R_RoleID]) VALUES (2, 1)
/****** Object:  StoredProcedure [dbo].[sys_UserRolesInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserRolesInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_UserRolesInsertUpdateDelete]
(	

	@R_UserID	 int = 0,	-- 用户ID与sys_User表中UserID相关
	@R_RoleID	 int = 0,	-- 用户所属角色ID与Sys_Roles关联
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_UserRoles( 
			R_UserID,
			R_RoleID
		) VALUES (	
			@R_UserID,
			@R_RoleID
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_UserRoles SET	
			R_UserID = @R_UserID,
			R_RoleID = @R_RoleID
		WHERE ( R_UserID = @R_UserID and R_RoleID = @R_RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_UserRoles	WHERE ( R_UserID = @R_UserID and R_RoleID = @R_RoleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_UserInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_UserInsertUpdateDelete]
(	

	@UserID	 int = 0,	-- 用户ID号
	@U_LoginName	 nvarchar(20) = '''',	-- 登陆名
	@U_Password	 varchar(32) = '''',	-- 密码md5加密字符
	@U_CName	 nvarchar(20) = '''',	-- 中文姓名
	@U_EName	 varchar(50) = '''',	-- 英文名
	@U_GroupID	 int = 0,	-- 部门ID号与sys_Group表中GroupID关联
	@U_Email	 varchar(100) = '''',	-- 电子邮件
	@U_Type	 tinyint = 0,	-- 用户类型0:超级用户1:普通用户
	@U_Status	 tinyint = 0,	-- 当前状态0:正常 1:禁止
	@U_Licence	 varchar(30) = '''',	-- 用户序列号
	@U_Mac	 varchar(50) = '''',	-- 锁定机器硬件地址
	@U_Remark	 nvarchar(200) = '''',	-- 备注说明
	@U_IDCard	 varchar(30) = '''',	-- 身份证号码
	@U_Sex	 tinyint = 0,	-- 性别1:男0:女
	@U_BirthDay	 datetime = Null,	-- 出生日期
	@U_MobileNo	 varchar(15) = '''',	-- 手机号
	@U_UserNO	 varchar(20) = '''',	-- 员工编号
	@U_WorkStartDate	 datetime = Null,	-- 到职日期
	@U_WorkEndDate	 datetime = Null,	-- 离职日期
	@U_CompanyMail	 varchar(255) = '''',	-- 公司邮件地址
	@U_Title	 int = 0,	-- 职称与应用字段关联
	@U_Extension	 varchar(10) = '''',	-- 分机号
	@U_HomeTel	 varchar(20) = '''',	-- 家中电话
	@U_PhotoUrl	 nvarchar(255) = '''',	-- 用户照片网址
	@U_DateTime	 datetime = Null,	-- 操作时间
	@U_LastIP	 varchar(15) = '''',	-- 最后访问IP
	@U_LastDateTime	 datetime = Null,	-- 最后访问时间
	@U_ExtendField	 ntext = '''',	-- 扩展字段
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_User( 
			U_LoginName,
			U_Password,
			U_CName,
			U_EName,
			U_GroupID,
			U_Email,
			U_Type,
			U_Status,
			U_Licence,
			U_Mac,
			U_Remark,
			U_IDCard,
			U_Sex,
			U_BirthDay,
			U_MobileNo,
			U_UserNO,
			U_WorkStartDate,
			U_WorkEndDate,
			U_CompanyMail,
			U_Title,
			U_Extension,
			U_HomeTel,
			U_PhotoUrl,
			U_DateTime,
			U_LastIP,
			U_LastDateTime,
			U_ExtendField
		) VALUES (	
			@U_LoginName,
			@U_Password,
			@U_CName,
			@U_EName,
			@U_GroupID,
			@U_Email,
			@U_Type,
			@U_Status,
			@U_Licence,
			@U_Mac,
			@U_Remark,
			@U_IDCard,
			@U_Sex,
			@U_BirthDay,
			@U_MobileNo,
			@U_UserNO,
			@U_WorkStartDate,
			@U_WorkEndDate,
			@U_CompanyMail,
			@U_Title,
			@U_Extension,
			@U_HomeTel,
			@U_PhotoUrl,
			@U_DateTime,
			@U_LastIP,
			@U_LastDateTime,
			@U_ExtendField
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_User SET	
			U_LoginName = @U_LoginName,
			U_Password = @U_Password,
			U_CName = @U_CName,
			U_EName = @U_EName,
			U_GroupID = @U_GroupID,
			U_Email = @U_Email,
			U_Type = @U_Type,
			U_Status = @U_Status,
			U_Licence = @U_Licence,
			U_Mac = @U_Mac,
			U_Remark = @U_Remark,
			U_IDCard = @U_IDCard,
			U_Sex = @U_Sex,
			U_BirthDay = @U_BirthDay,
			U_MobileNo = @U_MobileNo,
			U_UserNO = @U_UserNO,
			U_WorkStartDate = @U_WorkStartDate,
			U_WorkEndDate = @U_WorkEndDate,
			U_CompanyMail = @U_CompanyMail,
			U_Title = @U_Title,
			U_Extension = @U_Extension,
			U_HomeTel = @U_HomeTel,
			U_PhotoUrl = @U_PhotoUrl,
			U_DateTime = @U_DateTime,
			U_LastIP = @U_LastIP,
			U_LastDateTime = @U_LastDateTime,
			U_ExtendField = @U_ExtendField
		WHERE (UserID = @UserID)
		
		SET @ReturnValue = @UserID
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_User	WHERE (UserID = @UserID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue




' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_SystemInfoInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_SystemInfoInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_SystemInfoInsertUpdateDelete]
(	

	@SystemID	 int = 0,	-- 自动ID
	@S_Name	 nvarchar(50) = '''',	-- 系统名称
	@S_Version	 nvarchar(50) = '''',	-- 版本号
	@S_SystemConfigData	 image ,	-- 系统配置信息
	@S_Licensed	 varchar(50) = '''',	-- 序列号
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_SystemInfo( 
			S_Name,
			S_Version,
			S_SystemConfigData,
			S_Licensed
		) VALUES (	
			@S_Name,
			@S_Version,
			@S_SystemConfigData,
			@S_Licensed
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_SystemInfo SET	
			S_Name = @S_Name,
			S_Version = @S_Version,
			S_SystemConfigData = @S_SystemConfigData,
			S_Licensed = @S_Licensed
		WHERE (SystemID = @SystemID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_SystemInfo	WHERE (SystemID = @SystemID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue




' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_RolesInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RolesInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'





-- 创建更新删除
CREATE  PROCEDURE [dbo].[sys_RolesInsertUpdateDelete]
(	

	@RoleID	 int = 0,	-- 角色ID自动ID
	@R_UserID	 int = 0,	-- 角角所属用户ID
	@R_RoleName	 nvarchar(50) = '''',	-- 角色名称
	@R_Description	 nvarchar(255) = '''',	-- 角色介绍
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_Roles( 
			R_UserID,
			R_RoleName,
			R_Description
		) VALUES (	
			@R_UserID,
			@R_RoleName,
			@R_Description
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_Roles SET	
			R_UserID = @R_UserID,
			R_RoleName = @R_RoleName,
			R_Description = @R_Description
		WHERE (RoleID = @RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_Roles	WHERE (RoleID = @RoleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue




' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_RolePermissionInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RolePermissionInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_RolePermissionInsertUpdateDelete]
(	

	@PermissionID	 int = 0,	-- 角色应用权限自动ID
	@P_RoleID	 int = 0,	-- 角色ID与sys_Roles表中RoleID相
	@P_ApplicationID	 int = 0,	-- 角色所属应用ID与sys_Applicatio
	@P_PageCode	 varchar(20) = '''',	-- 角色应用中页面权限代码
	@P_Value	 int = 0,	-- 权限值
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_RolePermission( 
			P_RoleID,
			P_ApplicationID,
			P_PageCode,
			P_Value
		) VALUES (	
			@P_RoleID,
			@P_ApplicationID,
			@P_PageCode,
			@P_Value
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_RolePermission SET	
			P_RoleID = @P_RoleID,
			P_ApplicationID = @P_ApplicationID,
			P_PageCode = @P_PageCode,
			P_Value = @P_Value
		WHERE (PermissionID = @PermissionID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_RolePermission	WHERE (PermissionID = @PermissionID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_RoleApplicationInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RoleApplicationInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_RoleApplicationInsertUpdateDelete]
(	

	@A_RoleID	 int = 0,	-- 角色ID与sys_Roles中RoleID相关
	@A_ApplicationID	 int = 0,	-- 应用ID与sys_Applications中Appl
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_RoleApplication( 
			A_RoleID,
			A_ApplicationID
		) VALUES (	
			@A_RoleID,
			@A_ApplicationID
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_RoleApplication SET	
			A_RoleID = @A_RoleID,
			A_ApplicationID = @A_ApplicationID
		WHERE ( A_RoleID= @A_RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_RoleApplication	WHERE ( A_RoleID= @A_RoleID and A_ApplicationID = @A_ApplicationID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_OnlineInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_OnlineInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_OnlineInsertUpdateDelete]
(	

	@OnlineID	 int = 0,	-- 自动ID
	@O_SessionID	 varchar(24) = '''',	-- 用户SessionID
	@O_UserName	 nvarchar(20) = '''',	-- 用户名
	@O_Ip	 varchar(15) = '''',	-- 用户IP地址
	@O_LoginTime	 datetime = Null,	-- 登陆时间
	@O_LastTime	 datetime = Null,	-- 最后访问时间
	@O_LastUrl	 nvarchar(500) = '''',	-- 最后请求网站
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_Online( 
			O_SessionID,
			O_UserName,
			O_Ip,
			O_LoginTime,
			O_LastTime,
			O_LastUrl
		) VALUES (	
			@O_SessionID,
			@O_UserName,
			@O_Ip,
			@O_LoginTime,
			@O_LastTime,
			@O_LastUrl
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_Online SET	
			O_SessionID = @O_SessionID,
			O_UserName = @O_UserName,
			O_Ip = @O_Ip,
			O_LoginTime = @O_LoginTime,
			O_LastTime = @O_LastTime,
			O_LastUrl = @O_LastUrl
		WHERE (OnlineID = @OnlineID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_Online	WHERE (OnlineID = @OnlineID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue



' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_ModuleInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ModuleInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_ModuleInsertUpdateDelete]
(	

	@ModuleID	 int = 0,	-- 功能模块ID号
	@M_ApplicationID	 int = 0,	-- 所属应用程序ID
	@M_ParentID	 int = 0,	-- 所属父级模块ID与ModuleID关联,0为顶级
	@M_PageCode	 varchar(6) = '''',	-- 模块编码Parent为0,则为S00(xx),否则为S00M00(xx)
	@M_CName	 nvarchar(50) = '''',	-- 模块/栏目名称当ParentID为0为模块名称
	@M_Directory	 nvarchar(255) = '''',	-- 模块/栏目目录名
	@M_OrderLevel	 varchar(4) = '''',	-- 当前所在排序级别支持双层99级菜单
	@M_IsSystem	 tinyint = 0,	-- 是否为系统模块1:是0:否如为系统则无法修改
	@M_Close	 tinyint = 0,	-- 是否关闭1:是0:否
	@M_Icon		 nvarchar(255) = '''', --默认图标
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_Module( 
			M_ApplicationID,
			M_ParentID,
			M_PageCode,
			M_CName,
			M_Directory,
			M_OrderLevel,
			M_IsSystem,
			M_Close,
			M_Icon
		) VALUES (	
			@M_ApplicationID,
			@M_ParentID,
			@M_PageCode,
			@M_CName,
			@M_Directory,
			@M_OrderLevel,
			@M_IsSystem,
			@M_Close,
			@M_Icon
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_Module SET	
			M_ApplicationID = @M_ApplicationID,
			M_ParentID = @M_ParentID,
			M_PageCode = @M_PageCode,
			M_CName = @M_CName,
			M_Directory = @M_Directory,
			M_OrderLevel = @M_OrderLevel,
			M_IsSystem = @M_IsSystem,
			M_Close = @M_Close,
			M_Icon = @M_Icon
		WHERE (ModuleID = @ModuleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_Module	WHERE (ModuleID = @ModuleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_ModuleExtPermissionInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ModuleExtPermissionInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_ModuleExtPermissionInsertUpdateDelete]
(	

	@ExtPermissionID	 int = 0,	-- 扩展权限ID
	@ModuleID	 int = 0,	-- 模块ID
	@PermissionName	 nvarchar(100) = '''',	-- 权限名称
	@PermissionValue	 int = 0,	-- 权限值
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_ModuleExtPermission( 
			ModuleID,
			PermissionName,
			PermissionValue
		) VALUES (	
			@ModuleID,
			@PermissionName,
			@PermissionValue
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_ModuleExtPermission SET	
			ModuleID = @ModuleID,
			PermissionName = @PermissionName,
			PermissionValue = @PermissionValue
		WHERE (ExtPermissionID = @ExtPermissionID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_ModuleExtPermission	WHERE (ExtPermissionID = @ExtPermissionID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_GroupInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_GroupInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_GroupInsertUpdateDelete]
(	

	@GroupID	 int = 0,	-- 分类ID号
	@G_CName	 nvarchar(50) = '''',	-- 分类中文说明
	@G_ParentID	 int = 0,	-- 上级分类ID0:为最高级
	@G_ShowOrder	 int = 0,	-- 显示顺序
	@G_Level	 int = 0,	-- 当前分类所在层数
	@G_ChildCount	 int = 0,	-- 当前分类子分类数
	@G_Delete	 tinyint = 0,	-- 是否删除1:是0:否
	@G_Type	 tinyint = 0,	-- 部门类型，0表示非医院部门，1表示医院部门
	@G_Code	 varchar(20) = '''',	-- 行政代码
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_Group( 
			G_CName,
			G_ParentID,
			G_ShowOrder,
			G_Level,
			G_ChildCount,
			G_Delete,
			G_Type,
			G_Code
		) VALUES (	
			@G_CName,
			@G_ParentID,
			@G_ShowOrder,
			@G_Level,
			@G_ChildCount,
			@G_Delete,
			@G_Type,
			@G_Code
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_Group SET	
			G_CName = @G_CName,
			G_ParentID = @G_ParentID,
			G_ShowOrder = @G_ShowOrder,
			G_Level = @G_Level,
			G_ChildCount = @G_ChildCount,
			G_Delete = @G_Delete,
			G_Type = @G_Type,
			G_Code = @G_Code
		WHERE (GroupID = @GroupID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_Group	WHERE (GroupID = @GroupID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_FieldValueInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_FieldValueInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_FieldValueInsertUpdateDelete]
(	

	@ValueID	 int = 0,	-- 索引ID号
	@V_F_Key	 varchar(50) = '''',	-- 与sys_Field表中F_Key字段关联
	@V_Text	 nvarchar(100) = '''',	-- 中文说明
	@V_Code	 nvarchar(100) = '''',	-- 编码
	@V_ShowOrder	 int = 0,	-- 同级显示顺序
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_FieldValue( 
			V_F_Key,
			V_Text,
			V_Code,
			V_ShowOrder
		) VALUES (	
			@V_F_Key,
			@V_Text,
			@V_Code,
			@V_ShowOrder
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_FieldValue SET	
			V_F_Key = @V_F_Key,
			V_Text = @V_Text,
			V_Code = @V_Code,
			V_ShowOrder = @V_ShowOrder
		WHERE (ValueID = @ValueID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_FieldValue	WHERE (ValueID = @ValueID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_FieldInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_FieldInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_FieldInsertUpdateDelete]
(	

	@FieldID	 int = 0,	-- 应用字段ID号
	@F_Key	 varchar(50) = '''',	-- 应用字段关键字
	@F_CName	 nvarchar(50) = '''',	-- 应用字段中文说明
	@F_Remark	 nvarchar(200) = '''',	-- 描述说明
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_Field( 
			F_Key,
			F_CName,
			F_Remark
		) VALUES (	
			@F_Key,
			@F_CName,
			@F_Remark
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_Field SET	
			F_Key = @F_Key,
			F_CName = @F_CName,
			F_Remark = @F_Remark
		WHERE (FieldID = @FieldID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_Field	WHERE (FieldID = @FieldID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_EventInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_EventInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_EventInsertUpdateDelete]
(	

	@EventID	 int = 0,	-- 事件ID号
	@E_U_LoginName	 nvarchar(20) = '''',	-- 用户名
	@E_UserID	 int = 0,	-- 操作时用户ID与sys_Users中UserID
	@E_DateTime	 datetime = Null,	-- 事件发生的日期及时间
	@E_ApplicationID	 int = 0,	-- 所属应用程序ID与sys_Applicatio
	@E_A_AppName	 nvarchar(50) = '''',	-- 所属应用名称
	@E_M_Name	 nvarchar(50) = '''',	-- PageCode模块名称与sys_Module相同
	@E_M_PageCode	 varchar(6) = '''',	-- 发生事件时模块名称
	@E_From	 nvarchar(500) = '''',	-- 来源
	@E_Type	 tinyint = 0,	-- 日记类型,1:操作日记2:安全日志3
	@E_IP	 varchar(15) = '''',	-- 客户端IP地址
	@E_Record	 nvarchar(500) = '''',	-- 详细描述
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_Event( 
			E_U_LoginName,
			E_UserID,
			E_DateTime,
			E_ApplicationID,
			E_A_AppName,
			E_M_Name,
			E_M_PageCode,
			E_From,
			E_Type,
			E_IP,
			E_Record
		) VALUES (	
			@E_U_LoginName,
			@E_UserID,
			@E_DateTime,
			@E_ApplicationID,
			@E_A_AppName,
			@E_M_Name,
			@E_M_PageCode,
			@E_From,
			@E_Type,
			@E_IP,
			@E_Record
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_Event SET	
			E_U_LoginName = @E_U_LoginName,
			E_UserID = @E_UserID,
			E_DateTime = @E_DateTime,
			E_ApplicationID = @E_ApplicationID,
			E_A_AppName = @E_A_AppName,
			E_M_Name = @E_M_Name,
			E_M_PageCode = @E_M_PageCode,
			E_From = @E_From,
			E_Type = @E_Type,
			E_IP = @E_IP,
			E_Record = @E_Record
		WHERE (EventID = @EventID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_Event	WHERE (EventID = @EventID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







' 
END
GO
/****** Object:  StoredProcedure [dbo].[sys_ApplicationsInsertUpdateDelete]    Script Date: 06/08/2013 10:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ApplicationsInsertUpdateDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'




-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_ApplicationsInsertUpdateDelete]
(	

	@ApplicationID	 int = 0,	-- 自动ID 1:为系统管理应用
	@A_AppName	 nvarchar(50) = '''',	-- 应用名称
	@A_AppDescription	 nvarchar(200) = '''',	-- 应用介绍
	@A_AppUrl	 varchar(50) = '''',	-- 应用Url地址
	@DB_Option_Action_  nvarchar(20) = ''''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_=''Insert'')
	BEGIN
		INSERT INTO sys_Applications( 
			A_AppName,
			A_AppDescription,
			A_AppUrl
		) VALUES (	
			@A_AppName,
			@A_AppDescription,
			@A_AppUrl
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_=''Update'')
	BEGIN
		UPDATE sys_Applications SET	
			A_AppName = @A_AppName,
			A_AppDescription = @A_AppDescription,
			A_AppUrl = @A_AppUrl
		WHERE (ApplicationID = @ApplicationID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_=''Delete'')
	BEGIN
		DELETE sys_Applications	WHERE (ApplicationID = @ApplicationID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







' 
END
GO
/****** Object:  Default [DF_AR_Announcement_A_Title]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AR_Announcement_A_Title]') AND parent_object_id = OBJECT_ID(N'[dbo].[AR_Announcement]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AR_Announcement_A_Title]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AR_Announcement] ADD  CONSTRAINT [DF_AR_Announcement_A_Title]  DEFAULT ('') FOR [A_Title]
END


End
GO
/****** Object:  Default [DF_AR_Announcement_A_Detail]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AR_Announcement_A_Detail]') AND parent_object_id = OBJECT_ID(N'[dbo].[AR_Announcement]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AR_Announcement_A_Detail]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AR_Announcement] ADD  CONSTRAINT [DF_AR_Announcement_A_Detail]  DEFAULT ('') FOR [A_Content]
END


End
GO
/****** Object:  Default [DF_AR_Report_R_Detail]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AR_Report_R_Detail]') AND parent_object_id = OBJECT_ID(N'[dbo].[AR_Report]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AR_Report_R_Detail]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AR_Report] ADD  CONSTRAINT [DF_AR_Report_R_Detail]  DEFAULT ('') FOR [R_Content]
END


End
GO
/****** Object:  Default [DF_education_Activity_A_Duration]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Activity_A_Duration]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Activity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Activity_A_Duration]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Activity] ADD  CONSTRAINT [DF_education_Activity_A_Duration]  DEFAULT ((0)) FOR [A_Duration]
END


End
GO
/****** Object:  Default [DF_education_Activity_A_Partners]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Activity_A_Partners]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Activity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Activity_A_Partners]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Activity] ADD  CONSTRAINT [DF_education_Activity_A_Partners]  DEFAULT ('') FOR [A_Partners]
END


End
GO
/****** Object:  Default [DF_education_Activity_A_Missionary]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Activity_A_Missionary]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Activity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Activity_A_Missionary]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Activity] ADD  CONSTRAINT [DF_education_Activity_A_Missionary]  DEFAULT ('') FOR [A_Missionary]
END


End
GO
/****** Object:  Default [DF_education_Activity_A_Number]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Activity_A_Number]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Activity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Activity_A_Number]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Activity] ADD  CONSTRAINT [DF_education_Activity_A_Number]  DEFAULT ((0)) FOR [A_Number]
END


End
GO
/****** Object:  Default [DF_education_Prescription_P_Content]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_education_Prescription_P_Content]') AND parent_object_id = OBJECT_ID(N'[dbo].[education_Prescription]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_education_Prescription_P_Content]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[education_Prescription] ADD  CONSTRAINT [DF_education_Prescription_P_Content]  DEFAULT ('') FOR [P_Content]
END


End
GO
/****** Object:  Default [DF_extend_Disability_D_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_extend_Disability_D_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[extend_Disability]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_extend_Disability_D_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[extend_Disability] ADD  CONSTRAINT [DF_extend_Disability_D_Note]  DEFAULT ('') FOR [D_Note]
END


End
GO
/****** Object:  Default [DF_extend_DiseaseHistory_D_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_extend_DiseaseHistory_D_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[extend_DiseaseHistory]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_extend_DiseaseHistory_D_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[extend_DiseaseHistory] ADD  CONSTRAINT [DF_extend_DiseaseHistory_D_Note]  DEFAULT ('') FOR [DH_Note]
END


End
GO
/****** Object:  Default [DF_extend_FamilyHistory_DH_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_extend_FamilyHistory_DH_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[extend_FamilyHistory]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_extend_FamilyHistory_DH_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[extend_FamilyHistory] ADD  CONSTRAINT [DF_extend_FamilyHistory_DH_Note]  DEFAULT ('') FOR [FH_Note]
END


End
GO
/****** Object:  Default [DF_record_Consultation_C_Cause]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Consultation_C_Cause]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_Consultation]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Consultation_C_Cause]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_Consultation] ADD  CONSTRAINT [DF_record_Consultation_C_Cause]  DEFAULT ('') FOR [C_Cause]
END


End
GO
/****** Object:  Default [DF_record_Consultation_C_Comments]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Consultation_C_Comments]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_Consultation]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Consultation_C_Comments]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_Consultation] ADD  CONSTRAINT [DF_record_Consultation_C_Comments]  DEFAULT ('') FOR [C_Comments]
END


End
GO
/****** Object:  Default [DF_record_DeathRegistration_D_Icd10ID]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_DeathRegistration_D_Icd10ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_DeathRegistration]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_DeathRegistration_D_Icd10ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_DeathRegistration] ADD  CONSTRAINT [DF_record_DeathRegistration_D_Icd10ID]  DEFAULT ((0)) FOR [D_Icd10ID]
END


End
GO
/****** Object:  Default [DF_record_DeathRegistration_D_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_DeathRegistration_D_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_DeathRegistration]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_DeathRegistration_D_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_DeathRegistration] ADD  CONSTRAINT [DF_record_DeathRegistration_D_Note]  DEFAULT ('') FOR [D_Note]
END


End
GO
/****** Object:  Default [DF_record_DeathRegistration_D_UserID]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_DeathRegistration_D_UserID]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_DeathRegistration]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_DeathRegistration_D_UserID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_DeathRegistration] ADD  CONSTRAINT [DF_record_DeathRegistration_D_UserID]  DEFAULT ((0)) FOR [D_UserID]
END


End
GO
/****** Object:  Default [DF_record_Family_F_FimaryTel]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_FimaryTel]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_FimaryTel]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_FimaryTel]  DEFAULT ('') FOR [F_FimaryTel]
END


End
GO
/****** Object:  Default [DF_record_Family_F_FimrayAddress]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_FimrayAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_FimrayAddress]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_FimrayAddress]  DEFAULT ('') FOR [F_FimrayAddress]
END


End
GO
/****** Object:  Default [DF_record_Family_F_HouseType]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_HouseType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_HouseType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_HouseType]  DEFAULT ((0)) FOR [F_HouseType]
END


End
GO
/****** Object:  Default [DF_record_Family_F_HouseArea]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_HouseArea]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_HouseArea]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_HouseArea]  DEFAULT ((0)) FOR [F_HouseArea]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Ventilation]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Ventilation]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Ventilation]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Ventilation]  DEFAULT ((0)) FOR [F_Ventilation]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Humidity]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Humidity]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Humidity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Humidity]  DEFAULT ((0)) FOR [F_Humidity]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Warm]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Warm]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Warm]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Warm]  DEFAULT ((0)) FOR [F_Warm]
END


End
GO
/****** Object:  Default [DF_record_Family_Lighting]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_Lighting]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_Lighting]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_Lighting]  DEFAULT ((0)) FOR [F_Lighting]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Sanitation]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Sanitation]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Sanitation]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Sanitation]  DEFAULT ((0)) FOR [F_Sanitation]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Kitchen]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Kitchen]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Kitchen]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Kitchen]  DEFAULT ((0)) FOR [F_Kitchen]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Fuel]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Fuel]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Fuel]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Fuel]  DEFAULT ((0)) FOR [F_Fuel]
END


End
GO
/****** Object:  Default [DF_record_Family_F_Water]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_Water]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_Water]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Water]  DEFAULT ((0)) FOR [F_Water]
END


End
GO
/****** Object:  Default [DF_record_Family_F_WasteDisposal]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_WasteDisposal]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_WasteDisposal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_WasteDisposal]  DEFAULT ((0)) FOR [F_WasteDisposal]
END


End
GO
/****** Object:  Default [DF_record_Family_F_LivestockBar]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_LivestockBar]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_LivestockBar]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_LivestockBar]  DEFAULT ((0)) FOR [F_LivestockBar]
END


End
GO
/****** Object:  Default [DF_record_Family_F_ToiletType]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Family_F_ToiletType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FamilyBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Family_F_ToiletType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_ToiletType]  DEFAULT ((0)) FOR [F_ToiletType]
END


End
GO
/****** Object:  Default [DF_record_FollowUp_F_PatientID]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_FollowUp_F_PatientID]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FollowUp]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_FollowUp_F_PatientID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FollowUp] ADD  CONSTRAINT [DF_record_FollowUp_F_PatientID]  DEFAULT ((0)) FOR [F_PatientID]
END


End
GO
/****** Object:  Default [DF_record_FollowUp_F_Status]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_FollowUp_F_Status]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_FollowUp]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_FollowUp_F_Status]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_FollowUp] ADD  CONSTRAINT [DF_record_FollowUp_F_Status]  DEFAULT ((0)) FOR [F_Status]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_BodyTemperature]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_BodyTemperature]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_BodyTemperature]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_BodyTemperature]  DEFAULT ((0)) FOR [H_BodyTemperature]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_PulseRate]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_PulseRate]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_PulseRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_PulseRate]  DEFAULT ((0)) FOR [H_PulseRate]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_RespiratoryRate]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_RespiratoryRate]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_RespiratoryRate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_RespiratoryRate]  DEFAULT ((0)) FOR [H_RespiratoryRate]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftDiastolicBloodPressure]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_LeftDiastolicBloodPressure]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_LeftDiastolicBloodPressure]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_LeftDiastolicBloodPressure]  DEFAULT ((0)) FOR [H_LeftDiastolic]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftSystolic]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_LeftSystolic]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_LeftSystolic]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_LeftSystolic]  DEFAULT ((0)) FOR [H_LeftSystolic]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftDiastolic1]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_LeftDiastolic1]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_LeftDiastolic1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_LeftDiastolic1]  DEFAULT ((0)) FOR [H_RightDiastolic]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftSystolic1]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_LeftSystolic1]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_LeftSystolic1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_LeftSystolic1]  DEFAULT ((0)) FOR [H_RightSystolic]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_Height]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_Height]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_Height]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_Height]  DEFAULT ((0)) FOR [H_Height]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_Weight]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_Weight]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_Weight]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_Weight]  DEFAULT ((0)) FOR [H_Weight]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_Result]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_Result]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_Result]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_Result]  DEFAULT ('') FOR [H_Result]
END


End
GO
/****** Object:  Default [DF_record_HealthCheck_H_Suggestion]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_HealthCheck_H_Suggestion]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_HealthCheck]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_HealthCheck_H_Suggestion]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_Suggestion]  DEFAULT ('') FOR [H_Suggestion]
END


End
GO
/****** Object:  Default [DF_record_Medication_MedicationID]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_Medication_MedicationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_Medication]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_Medication_MedicationID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_Medication] ADD  CONSTRAINT [DF_record_Medication_MedicationID]  DEFAULT ((0)) FOR [MedicationID]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingUnits]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_WorkingUnits]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_WorkingUnits]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_WorkingUnits]  DEFAULT ('') FOR [U_WorkingUnits]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingContactName]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_WorkingContactName]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_WorkingContactName]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_WorkingContactName]  DEFAULT ('') FOR [U_WorkingContactName]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingContactPhone]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_WorkingContactPhone]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_WorkingContactPhone]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_WorkingContactPhone]  DEFAULT ('') FOR [U_WorkingContactTel]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_BloodType]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_BloodType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_BloodType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_BloodType]  DEFAULT ((0)) FOR [U_BloodType]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_MarriageStatus]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_MarriageStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_MarriageStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_MarriageStatus]  DEFAULT ((0)) FOR [U_MarriageStatus]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_PermanentType]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_PermanentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_PermanentType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_PermanentType]  DEFAULT ((0)) FOR [U_PermanentType]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_Education]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_Education]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_Education]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_Education]  DEFAULT ((0)) FOR [U_Education]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_PaymentType]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_PaymentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_PaymentType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_PaymentType]  DEFAULT ('') FOR [U_PaymentType]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_SocialSecurityNO]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_SocialSecurityNO]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_SocialSecurityNO]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_SocialSecurityNO]  DEFAULT ('') FOR [U_SocialNO]
END


End
GO
/****** Object:  Default [DF_record_BaseInfo_B_FamilyNO]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_BaseInfo_B_FamilyNO]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_BaseInfo_B_FamilyNO]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_FamilyNO]  DEFAULT ((0)) FOR [U_FamilyCode]
END


End
GO
/****** Object:  Default [DF_record_UserBaseInfo_U_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_record_UserBaseInfo_U_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[record_UserBaseInfo]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_record_UserBaseInfo_U_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_UserBaseInfo_U_Note]  DEFAULT ('') FOR [U_Note]
END


End
GO
/****** Object:  Default [DF_supervision_Info_I_Content]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_supervision_Info_I_Content]') AND parent_object_id = OBJECT_ID(N'[dbo].[supervision_Info]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_supervision_Info_I_Content]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[supervision_Info] ADD  CONSTRAINT [DF_supervision_Info_I_Content]  DEFAULT ('') FOR [I_Content]
END


End
GO
/****** Object:  Default [DF_supervision_Inspect_I_Note]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_supervision_Inspect_I_Note]') AND parent_object_id = OBJECT_ID(N'[dbo].[supervision_Inspect]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_supervision_Inspect_I_Note]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[supervision_Inspect] ADD  CONSTRAINT [DF_supervision_Inspect_I_Note]  DEFAULT ('') FOR [I_Note]
END


End
GO
/****** Object:  Default [DF__sys_Event__E_Dat__7F60ED59]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Event__E_Dat__7F60ED59]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Event]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Event__E_Dat__7F60ED59]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Event] ADD  CONSTRAINT [DF__sys_Event__E_Dat__7F60ED59]  DEFAULT (getdate()) FOR [E_DateTime]
END


End
GO
/****** Object:  Default [DF__sys_Event__E_Typ__00551192]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Event__E_Typ__00551192]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Event]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Event__E_Typ__00551192]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Event] ADD  CONSTRAINT [DF__sys_Event__E_Typ__00551192]  DEFAULT ((1)) FOR [E_Type]
END


End
GO
/****** Object:  Default [DF__sys_Field__V_Sho__0519C6AF]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Field__V_Sho__0519C6AF]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_FieldValue]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Field__V_Sho__0519C6AF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_FieldValue] ADD  CONSTRAINT [DF__sys_Field__V_Sho__0519C6AF]  DEFAULT ((0)) FOR [V_ShowOrder]
END


End
GO
/****** Object:  Default [DF__sys_Group__G_Par__07F6335A]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Group__G_Par__07F6335A]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Group]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Group__G_Par__07F6335A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Group] ADD  CONSTRAINT [DF__sys_Group__G_Par__07F6335A]  DEFAULT ((0)) FOR [G_ParentID]
END


End
GO
/****** Object:  Default [DF__sys_Group__G_Sho__08EA5793]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_Group__G_Sho__08EA5793]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Group]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_Group__G_Sho__08EA5793]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Group] ADD  CONSTRAINT [DF__sys_Group__G_Sho__08EA5793]  DEFAULT ((0)) FOR [G_ShowOrder]
END


End
GO
/****** Object:  Default [DF_sys_Group_G_Type]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Group_G_Type]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Group]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_sys_Group_G_Type]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Group] ADD  CONSTRAINT [DF_sys_Group_G_Type]  DEFAULT ((0)) FOR [G_Type]
END


End
GO
/****** Object:  Default [DF_sys_Group_G_Code]    Script Date: 06/08/2013 10:03:43 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Group_G_Code]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Group]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_sys_Group_G_Code]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Group] ADD  CONSTRAINT [DF_sys_Group_G_Code]  DEFAULT ('') FOR [G_Code]
END


End
GO
/****** Object:  Default [DF__sys_User__U_Type__1920BF5C]    Script Date: 06/08/2013 10:03:44 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_User__U_Type__1920BF5C]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_User__U_Type__1920BF5C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] ADD  CONSTRAINT [DF__sys_User__U_Type__1920BF5C]  DEFAULT ((1)) FOR [U_Type]
END


End
GO
/****** Object:  Default [DF__sys_User__U_Stat__1A14E395]    Script Date: 06/08/2013 10:03:44 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__sys_User__U_Stat__1A14E395]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__sys_User__U_Stat__1A14E395]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] ADD  CONSTRAINT [DF__sys_User__U_Stat__1A14E395]  DEFAULT ((1)) FOR [U_Status]
END


End
GO
/****** Object:  Default [DF_sys_User_U_HospitalGroupID]    Script Date: 06/08/2013 10:03:44 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_User_U_HospitalGroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_sys_User_U_HospitalGroupID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] ADD  CONSTRAINT [DF_sys_User_U_HospitalGroupID]  DEFAULT ((0)) FOR [U_HospitalGroupID]
END


End
GO
