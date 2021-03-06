USE [CourseRegistration]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[AccountCode] [varchar](20) NOT NULL,
	[Enable] [int] NULL,
	[Type] [int] NULL,
	[PassWord] [varchar](20) NULL,
	[FullName] [nvarchar](100) NULL,
	[Sex] [int] NULL,
	[Birthday] [date] NULL,
	[Address] [nvarchar](300) NULL,
	[MajorsCode] [varchar](20) NULL,
 CONSTRAINT [PK_Acct] PRIMARY KEY CLUSTERED 
(
	[AccountCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Class]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Class](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Enable] [int] NULL,
	[AccountNumber] [int] NULL,
	[MaxGroup] [int] NULL,
	[HK] [int] NULL,
	[ThematicCode] [varchar](20) NOT NULL,
	[TeacherCode] [varchar](20) NULL,
	[TimeRes] [datetime] NULL,
	[TimeGroup] [datetime] NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Group](
	[GroupCode] [varchar](20) NOT NULL,
	[GroupName] [nvarchar](100) NULL,
	[Enable] [int] NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[GroupCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group_Regis]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Group_Regis](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupCode] [varchar](20) NOT NULL,
	[RegisID] [int] NOT NULL,
	[IsLeader] [int] NOT NULL,
	[Enable] [int] NULL,
 CONSTRAINT [PK_Group_Regis] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[GroupCode] ASC,
	[RegisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Majors]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Majors](
	[MajorsCode] [varchar](20) NOT NULL,
	[MajorsName] [nvarchar](200) NULL,
	[SuccessMaticNumber] [int] NULL,
	[HistoryNumber] [int] NULL,
 CONSTRAINT [PK_Majors_1] PRIMARY KEY CLUSTERED 
(
	[MajorsCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassID] [int] NULL,
	[AccountCode] [varchar](20) NOT NULL,
	[AVG] [float] NULL,
	[Enable] [int] NULL,
 CONSTRAINT [PK_Registration_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectsCode] [nvarchar](20) NOT NULL,
	[SubjectsName] [nvarchar](100) NULL,
	[MajorsCode] [varchar](20) NULL,
	[Enable] [int] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[SubjectsLimit] [int] NULL,
	[SubjectsNum] [int] NULL,
 CONSTRAINT [PK_Subjects_1] PRIMARY KEY CLUSTERED 
(
	[SubjectsCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Thematic]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Thematic](
	[ThematicCode] [varchar](20) NOT NULL,
	[SubjectsCode] [nvarchar](20) NULL,
	[ThematicName] [varchar](100) NULL,
	[Enable] [int] NULL,
	[ThematicLimit] [int] NULL,
	[IsCompel] [int] NULL,
 CONSTRAINT [PK_Thematic_1] PRIMARY KEY CLUSTERED 
(
	[ThematicCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Majors] FOREIGN KEY([MajorsCode])
REFERENCES [dbo].[Majors] ([MajorsCode])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Majors]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Account] FOREIGN KEY([TeacherCode])
REFERENCES [dbo].[Account] ([AccountCode])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Account]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Thematic] FOREIGN KEY([ThematicCode])
REFERENCES [dbo].[Thematic] ([ThematicCode])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Thematic]
GO
ALTER TABLE [dbo].[Group_Regis]  WITH CHECK ADD  CONSTRAINT [FK_Group_Regis_Group] FOREIGN KEY([GroupCode])
REFERENCES [dbo].[Group] ([GroupCode])
GO
ALTER TABLE [dbo].[Group_Regis] CHECK CONSTRAINT [FK_Group_Regis_Group]
GO
ALTER TABLE [dbo].[Group_Regis]  WITH CHECK ADD  CONSTRAINT [FK_Group_Regis_Registration] FOREIGN KEY([RegisID])
REFERENCES [dbo].[Registration] ([ID])
GO
ALTER TABLE [dbo].[Group_Regis] CHECK CONSTRAINT [FK_Group_Regis_Registration]
GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Account] FOREIGN KEY([AccountCode])
REFERENCES [dbo].[Account] ([AccountCode])
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_Account]
GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ID])
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_Class]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_Majors] FOREIGN KEY([MajorsCode])
REFERENCES [dbo].[Majors] ([MajorsCode])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subjects_Majors]
GO
ALTER TABLE [dbo].[Thematic]  WITH CHECK ADD  CONSTRAINT [FK_Thematic_Subjects] FOREIGN KEY([SubjectsCode])
REFERENCES [dbo].[Subjects] ([SubjectsCode])
GO
ALTER TABLE [dbo].[Thematic] CHECK CONSTRAINT [FK_Thematic_Subjects]
GO
/****** Object:  StoredProcedure [dbo].[CloseClass]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[CloseClass] @ThematicCode VARCHAR(20), @TeacherCode VARCHAR(20)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@ThematicCode,'') = '' OR ISNULL(@TeacherCode,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại chuyên đề cần đóng' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Class WHERE ThematicCode = @ThematicCode AND TeacherCode = @TeacherCode)
			BEGIN
				SELECT N'Chuyền đề không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END

		UPDATE Class SET Enable = 0 WHERE ThematicCode = @ThematicCode AND TeacherCode = @TeacherCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Đóng chuyên đề thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[CreateAccount]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[CreateAccount] @AccountCode VARCHAR(20),@PassWord VARCHAR(20) ,@PWConfirm VARCHAR(20), @FullName VARCHAR(100), @Enable INTEGER, @Type INTEGER, @Sex INTEGER, @BirthDay DATE, @Address VARCHAR(300), @MajorsCode VARCHAR(20)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@AccountCode,'') = '' OR ISNULL(@PassWord,'') = '' OR ISNULL(@PWConfirm,'') = '' OR ISNULL(@FullName,'') = '' OR ISNULL(@Enable,'') = '' OR ISNULL(@Sex,'') = '' OR ISNULL(@BirthDay,'') = '' OR ISNULL(@Address,'') = '')
			BEGIN
				SELECT N'Chưa nhập đầy đủ thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT TOP 1 * FROM Account WHERE AccountCode = @AccountCode)
			BEGIN
				SELECT N'Tên đăng nhập đã tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF (@PassWord != @PWConfirm)
			BEGIN
				SELECT N'Mật khẩu không trùng khớp' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Majors WHERE MajorsCode = @MajorsCode)
			BEGIN
				SELECT N'Ngành không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		INSERT INTO Account(AccountCode, PassWord, FullName, Enable, Type, Sex, Birthday, Address, MajorsCode) VALUES (@AccountCode, @PassWord, @FullName, @Enable, @Type, @Sex, @BirthDay, @Address, @MajorsCode)
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Tạo tài khoản thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[CreateClass]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[CreateClass] @TeacherCode VARCHAR(20), @StartDate DATETIME, @EndDate DATETIME, @Enable INTEGER, @MaxGroup INTEGER, @HK INTEGER, @ThematicCode VARCHAR(20), @TimeRes DATETIME, @TimeGroup DATETIME
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@StartDate,'') = '' OR ISNULL(@TeacherCode,'') = '' OR ISNULL(@EndDate,'') = '' OR ISNULL(@Enable,'') = '' OR ISNULL(@MaxGroup,'') = '' OR ISNULL(@ThematicCode,'') = '' OR ISNULL(@TimeRes,'') = '' OR ISNULL(@TimeGroup,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@MaxGroup <= 0)
			BEGIN
				SELECT N'Số lượng nhóm phải lớn hơn 0' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@TimeRes < @StartDate OR @TimeRes > @EndDate)
			BEGIN
				SELECT N'Hạn đăng ký chuyên ngành từ ngày bắt đầu đến khi kết thúc chuyên đề' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@TimeGroup < @StartDate OR @TimeGroup > @EndDate)
			BEGIN
				SELECT N'Hạn đăng ký nhóm từ ngày bắt đầu đến khi kết thúc chuyên đề' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Thematic WHERE ThematicCode = @ThematicCode AND Enable = 1)
			BEGIN
				SELECT N'Chuyên đề không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT TOP 1 * FROM Thematic WHERE ThematicCode = @ThematicCode AND Enable = 0)
			BEGIN
				SELECT N'Chuyên đề đã đóng' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@StartDate < @EndDate)
			BEGIN
				SELECT N'Ngày bắt đầu và kết thúc không hợp lệ' Message
				ROLLBACK TRAN
				RETURN
			END
		
		INSERT INTO Class(TeacherCode, StartDate, EndDate, Enable, MaxGroup, HK, ThematicCode, TimeRes, TimeGroup, AccountNumber) VALUES (@TeacherCode, @StartDate, @EndDate, @Enable, @MaxGroup, @HK, @ThematicCode, @TimeRes, @TimeGroup, 0)
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Mở chuyên ngành thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[CreateGroup]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[CreateGroup] @GroupCode VARCHAR(20), @GroupName  VARCHAR(100), @RegisID INTEGER, @IsLeader INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@GroupCode,'') = '' OR ISNULL(@GroupName,'') = '' OR ISNULL(@RegisID,'') = '' OR ISNULL(@IsLeader,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF((SELECT MaxGroup FROM Class) = ( SELECT COUNT(*) FROM [dbo].[Group] WHERE Enable = 1))
			BEGIN
				SELECT N'Không thể tạo thêm nhóm' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT TOP 1 * FROM [dbo].[Group] WHERE GroupCode != @GroupCode)
			BEGIN
				SELECT N'Nhóm đã tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		
		INSERT INTO [dbo].[Group](GroupCode, GroupName, Enable) VALUES (@GroupCode, @GroupName, 1)
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		INSERT INTO [dbo].[Group_Regis](GroupCode, RegisID, IsLeader, Enable) VALUES (@GroupCode, @RegisID, @IsLeader, 1)

		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không tạo nhóm được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Tạo nhóm thành công. Bạn là trưởng nhóm' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[CreateMajors]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[CreateMajors] @MajorsCode VARCHAR(20), @MajorsName VARCHAR(200), @SuccessMaticNumber INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@MajorsCode,'') = '' OR ISNULL(@MajorsName,'') = '' OR ISNULL(@SuccessMaticNumber,'') = '')
			BEGIN
				SELECT N'Chưa nhập đầy đủ thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@SuccessMaticNumber > 5 OR @SuccessMaticNumber < 0)
			BEGIN
				SELECT N'Số lượng chuyên đề hoàn thành từ 0 đến 5' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT TOP 1 * FROM Majors WHERE MajorsCode = @MajorsCode)
			BEGIN
				SELECT N'Mã ngành đã tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT TOP 1 * FROM Majors WHERE MajorsName = @MajorsName)
			BEGIN
				SELECT N'Tên ngành đã tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		INSERT INTO Majors(MajorsCode, MajorsName, SuccessMaticNumber, HistoryNumber) VALUES (@MajorsCode, @MajorsName, @SuccessMaticNumber, 0)
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Tạo ngành thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[CreateRegistration]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[CreateRegistration] @ClassID INTEGER, @AccountCode VARCHAR(20)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@ClassID,'') = '' OR ISNULL(@AccountCode,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(GETDATE() > (SELECT TimeRes FROM Class WHERE ID = @ClassID))
			BEGIN
				SELECT N'Quá thời gian đăng ký chuyên đề' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT * FROM Class WHERE ID = @ClassID AND Enable = 0)
			BEGIN
				SELECT N'Chuyên đề đã đóng' Message
				ROLLBACK TRAN
				RETURN
			END
		INSERT INTO Registration(ClassID, AccountCode, AVG, Enable) VALUES (@ClassID, @AccountCode, 0, 1)
		IF(@@ERROR = 0)
			BEGIN
				UPDATE Class SET AccountNumber = AccountNumber + 1 WHERE ID = @ClassID
				IF(@@ERROR = 0)
					BEGIN
						IF((SELECT AccountNumber FROM Class WHERE ID = @ClassID) > (SELECT t.ThematicLimit FROM Thematic t JOIN Class c ON t.ThematicCode = c.ThematicCode WHERE c.ID = @ClassID))
							BEGIN
								SELECT N'Vượt quá số lượng đăng ký' Message
								ROLLBACK TRAN
								RETURN
							END
						ELSE
							BEGIN
								UPDATE s SET s.SubjectsNum = s.SubjectsNum + 1 FROM Subjects s JOIN Thematic t ON s.SubjectsCode = t.SubjectsCode JOIN Class c ON c.ThematicCode = t.ThematicCode WHERE c.ID = @ClassID
								IF(@@ERROR = 0)
									BEGIN
										IF (SELECT s.SubjectsNum FROM Subjects s JOIN Thematic t ON s.SubjectsCode = t.SubjectsCode JOIN Class c ON c.ThematicCode = t.ThematicCode WHERE c.ID = @ClassID) > (SELECT s.SubjectsLimit FROM Subjects s JOIN Thematic t ON s.SubjectsCode = t.SubjectsCode JOIN Class c ON c.ThematicCode = t.ThematicCode WHERE c.ID = @ClassID)
											BEGIN
												SELECT N'Không đăng ký chuyên đề được. Thử lại sau' Message
												ROLLBACK TRAN
												RETURN
											END
										UPDATE m SET m.SuccessMaticNumber = m.SuccessMaticNumber + 1 FROM Majors m JOIN Subjects s ON m.MajorsCode = s.MajorsCode JOIN Thematic t ON s.SubjectsCode = t.SubjectsCode JOIN Class c ON c.ThematicCode = t.ThematicCode WHERE c.ID = @ClassID
										IF(@@ERROR = 0)
										BEGIN
											SELECT N'Không đăng ký chuyên đề được. Thử lại sau' Message
											ROLLBACK TRAN
											RETURN
										END
									END
								ELSE
									BEGIN
										SELECT N'Không đăng ký chuyên đề được. Thử lại sau' Message
										ROLLBACK TRAN
										RETURN
									END
							END
					END
				ELSE
					BEGIN
						SELECT N'Không đăng ký chuyên đề được. Thử lại sau' Message
						ROLLBACK TRAN
						RETURN
					END
			END
		ELSE
			BEGIN
				SELECT N'Không đăng ký chuyên đề được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Đăng ký chuyên đề thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[CreateSubjects]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[CreateSubjects] @SubjectsCode VARCHAR(20), @SubjectsName VARCHAR(200), @MajorsCode VARCHAR(20), @Enable INTEGER, @StartDate Date, @EndDate Date, @SubjectsLimit INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@SubjectsCode,'') = '' OR ISNULL(@SubjectsName,'') = '' OR ISNULL(@MajorsCode,'') = '' OR ISNULL(@Enable,'') = ''  OR ISNULL(@SubjectsLimit,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@SubjectsLimit <= 0)
			BEGIN
				SELECT N'Số lượng học sinh phải lớn hơn 0' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Majors WHERE MajorsCode = @MajorsCode)
			BEGIN
				SELECT N'Ngành không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT TOP 1 * FROM Subjects WHERE SubjectsCode = @SubjectsCode OR SubjectsName = @SubjectsName)
			BEGIN
				SELECT N'Môn học đã tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		INSERT INTO Subjects(SubjectsCode, SubjectsName, MajorsCode, Enable, StartDate, EndDate, SubjectsLimit, SubjectsNum) VALUES (@SubjectsCode, @SubjectsName, @MajorsCode, @Enable, @StartDate, @EndDate, @SubjectsLimit, 0)
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Tạo môn học thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[CreateThematic]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[CreateThematic] @ThematicCode VARCHAR(20), @ThematicName VARCHAR(200), @SubjectsCode VARCHAR(20), @Enable INTEGER, @ThematicLimit INTEGER, @IsCompel INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@ThematicCode,'') = '' OR ISNULL(@ThematicName,'') = '' OR ISNULL(@SubjectsCode,'') = '' OR ISNULL(@Enable,'') = '' OR ISNULL(@ThematicLimit,'') = '' OR ISNULL(@IsCompel,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@ThematicLimit <= 0)
			BEGIN
				SELECT N'Số lượng học sinh phải lớn hơn 0' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Subjects WHERE SubjectsCode = @SubjectsCode AND Enable = 1)
			BEGIN
				SELECT N'Bộ môn không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@ThematicLimit > (SELECT SubjectsLimit FROM Subjects WHERE SubjectsCode = @SubjectsCode))
			BEGIN
				SELECT N'Số lượng học sinh chuyên đề không được vượt quá số lượng học sinh bộ môn' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT * FROM Subjects WHERE SubjectsCode = @SubjectsCode AND Enable = 0)
			BEGIN
				SELECT N'Bộ môn đã đóng' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT TOP 1 * FROM Thematic WHERE ThematicCode = @ThematicCode OR ThematicName = @ThematicName)
			BEGIN
				SELECT N'Chuyên đề đã tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		INSERT INTO Thematic(ThematicCode, ThematicName, SubjectsCode, Enable, ThematicLimit, IsCompel) VALUES (@ThematicCode, @ThematicName, @SubjectsCode, @Enable, @ThematicLimit, @IsCompel)
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Tạo chuyên ngành thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[DeleteAccount]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[DeleteAccount] @AccountCode VARCHAR(30)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@AccountCode,'') = '')
			BEGIN
				SELECT N'Nhập tài khoản cần xóa' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Account WHERE AccountCode = @AccountCode)
			BEGIN
				SELECT N'Tài khoản không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		
		UPDATE Account SET Enable = 0 WHERE AccountCode = @AccountCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Xóa tài khoản thành công' Message
		IF EXISTS (SELECT * FROM Registration WHERE AccountCode = @AccountCode)
			BEGIN
				UPDATE Registration SET Enable = 0 WHERE AccountCode = @AccountCode
				IF(@@ERROR != 0)
					BEGIN
						SELECT N'Không thực hiện được. Thử lại sau' Message
						ROLLBACK TRAN
						RETURN
					END
				IF EXISTS (SELECT * FROM Class c JOIN Registration r ON c.ID = r.ClassID WHERE r.AccountCode = @AccountCode)
				BEGIN
					UPDATE Class SET AccountNumber = (SELECT c.AccountNumber - 1 FROM Class c JOIN Registration r ON c.ID = r.ClassID WHERE r.AccountCode = @AccountCode) WHERE ID IN (SELECT r.ID FROM Class c JOIN Registration r ON c.ID = r.ClassID WHERE r.AccountCode = @AccountCode)
					IF(@@ERROR != 0)
						BEGIN
							SELECT N'Không thực hiện được. Thử lại sau' Message
							ROLLBACK TRAN
							RETURN
						END
				END
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[DeleteGroup]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[DeleteGroup] @GroupCode VARCHAR(20), @RegisID INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@GroupCode,'') = '' OR ISNULL(@RegisID,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM [dbo].[Group_Regis] WHERE RegisID = @GroupCode AND IsLeader = 1)
			BEGIN
				SELECT N'Bạn không có quyền xóa nhóm' Message
				ROLLBACK TRAN
				RETURN
			END

		UPDATE [dbo].[Group] SET Enable = 0 WHERE GroupCode = @GroupCode
		IF(@@ERROR = 0)
			BEGIN
				UPDATE [dbo].[Group_Regis] SET Enable = 0 WHERE GroupCode = @GroupCode
				IF(@@ERROR != 0)
					BEGIN
						SELECT N'Không thực hiện được. Thử lại sau' Message
						ROLLBACK TRAN
						RETURN
					END
			END
		ELSE
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Xóa nhóm thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[DeleteSubjects]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[DeleteSubjects] @SubjectsCode VARCHAR(20)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@SubjectsCode,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại mã môn học cần xóa' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Subjects WHERE SubjectsCode = @SubjectsCode)
			BEGIN
				SELECT N'Môn học không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		
		IF EXISTS(SELECT * FROM Subjects s JOIN Thematic t ON s.SubjectsCode = t.SubjectsCode WHERE s.SubjectsCode = @SubjectsCode AND t.Enable = 1)
			BEGIN
				SELECT N'Không xóa được vì chuyên ngành vẫn còn mở.' Message
				ROLLBACK TRAN
				RETURN
			END

		UPDATE Subjects SET Enable = 0 WHERE SubjectsCode = @SubjectsCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Xóa môn học thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[DeleteThematic]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[DeleteThematic] @ThematicCode VARCHAR(20)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@ThematicCode,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại mã chuyên ngành cần xóa' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Thematic WHERE ThematicCode = @ThematicCode)
			BEGIN
				SELECT N'Chuyên ngành không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		
		IF EXISTS(SELECT * FROM Thematic t JOIN Class c ON t.ThematicCode = c.ThematicCode WHERE t.ThematicCode = @ThematicCode AND c.Enable = 1)
			BEGIN
				SELECT N'Không xóa được vì chuyên ngành vẫn còn mở.' Message
				ROLLBACK TRAN
				RETURN
			END

		UPDATE Thematic SET Enable = 0 WHERE ThematicCode = @ThematicCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Xóa chuyên ngành thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[DelteRegistration]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[DelteRegistration] @ClassID INTEGER, @AccountCode VARCHAR(20)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@ClassID,'') = '' OR ISNULL(@AccountCode,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Registration WHERE ClassID = @ClassID AND AccountCode = @AccountCode)
			BEGIN
				SELECT N'Không tồn tại sinh viên' Message
				ROLLBACK TRAN
				RETURN
			END
		UPDATE Registration SET Enable = 0 WHERE ClassID = @ClassID AND AccountCode = @AccountCode
		SELECT N'Hủy chuyên đề thành công' Message
		IF(@@ERROR = 0)
			BEGIN
				UPDATE Class SET AccountNumber = AccountNumber - 1 WHERE ID = @ClassID
				IF(@@ERROR = 0)
					BEGIN
						IF((SELECT AccountNumber FROM Class WHERE ID = @ClassID) > (SELECT t.ThematicLimit FROM Thematic t JOIN Class c ON t.ThematicCode = c.ThematicCode WHERE c.ID = @ClassID))
							BEGIN
								SELECT N'Vượt quá số lượng đăng ký' Message
								ROLLBACK TRAN
								RETURN
							END
						ELSE
							BEGIN
								UPDATE s SET s.SubjectsNum = s.SubjectsNum - 1 FROM Subjects s JOIN Thematic t ON s.SubjectsCode = t.SubjectsCode JOIN Class c ON c.ThematicCode = t.ThematicCode WHERE c.ID = @ClassID
								IF(@@ERROR = 0)
									BEGIN
										IF (SELECT s.SubjectsNum FROM Subjects s JOIN Thematic t ON s.SubjectsCode = t.SubjectsCode JOIN Class c ON c.ThematicCode = t.ThematicCode WHERE c.ID = @ClassID) > (SELECT s.SubjectsLimit FROM Subjects s JOIN Thematic t ON s.SubjectsCode = t.SubjectsCode JOIN Class c ON c.ThematicCode = t.ThematicCode WHERE c.ID = @ClassID)
											BEGIN
												SELECT N'Không hủy chuyên đề được. Thử lại sau' Message
												ROLLBACK TRAN
												RETURN
											END
									END
								ELSE
									BEGIN
										SELECT N'Không hủy chuyên đề được. Thử lại sau' Message
										ROLLBACK TRAN
										RETURN
									END
							END
					END
				ELSE
					BEGIN
						SELECT N'Không hủy chuyên đề được. Thử lại sau' Message
						ROLLBACK TRAN
						RETURN
					END
			END
		ELSE
			BEGIN
				SELECT N'Không hủy chuyên đề được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[GetAccountLogin]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter Proc [dbo].[GetAccountLogin] @AccountCode VARCHAR(20),@PassWord VARCHAR(20)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@AccountCode,'') = '' OR ISNULL(@PassWord,'') = '')
			BEGIN
				SELECT N'Chưa nhập đầy đủ thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT top 1 * FROM Account a WHERE AccountCode = @AccountCode)
			BEGIN
				SELECT N'Tên đăng nhập không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT TOP 1 * FROM Account WHERE PassWord = @PassWord AND PassWord IN (SELECT password FROM Account WHERE AccountCode = @AccountCode AND Enable = 1) AND AccountCode = @AccountCode)
			BEGIN
				SELECT  '1' Message
				SELECT TOP 1 * FROM Account WHERE PassWord = @PassWord AND PassWord IN (SELECT password FROM Account WHERE AccountCode = @AccountCode AND Enable = 1) AND AccountCode = @AccountCode
				IF(@@ERROR != 0)
					BEGIN
						SELECT N'Không thực hiện được. Thử lại sau' Message
						ROLLBACK TRAN
						RETURN
					END
				COMMIT TRAN
			END
		ELSE
			BEGIN
				SELECT N'Kiểm tra lại thông tin tài khoản' Message
				ROLLBACK TRAN
				RETURN
			END
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[JoinGroup]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[JoinGroup] @GroupCode VARCHAR(20), @RegisID INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@GroupCode,'') = '' OR ISNULL(@RegisID,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END

		INSERT INTO [dbo].[Group_Regis](GroupCode, RegisID, IsLeader, Enable) VALUES (@GroupCode, @RegisID, 0, 1)

		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không vào nhóm được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Nhập nhóm thành công.' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[OutGroup]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[OutGroup] @GroupCode VARCHAR(20), @RegisID INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@GroupCode,'') = '' OR ISNULL(@RegisID,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
	

		UPDATE [dbo].[Group_Regis] SET Enable = 0 WHERE GroupCode = @GroupCode AND RegisID = @RegisID
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Thoát nhóm thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[UpdateAccount] @AccountCode VARCHAR(20),@PassWord VARCHAR(20) ,@PWConfirm VARCHAR(20), @FullName VARCHAR(100), @Enable INTEGER, @Type INTEGER, @Sex INTEGER, @BirthDay DATE, @Address VARCHAR(300), @MajorsCode VARCHAR(20)
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@AccountCode,'') = '' OR ISNULL(@PassWord,'') = '' OR ISNULL(@PWConfirm,'') = '' OR ISNULL(@FullName,'') = '' OR ISNULL(@Enable,'') = '' OR ISNULL(@Sex,'') = '' OR ISNULL(@BirthDay,'') = '' OR ISNULL(@Address,'') = '')
			BEGIN
				SELECT N'Không để trống giá trị cập nhật' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Account WHERE AccountCode = @AccountCode)
			BEGIN
				SELECT N'Tài khoản không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF (@PassWord != @PWConfirm)
			BEGIN
				SELECT N'Mật khẩu không trùng khớp' Message
				ROLLBACK TRAN
				RETURN
			END
		IF (ISNULL(@MajorsCode,'') != '' AND NOT EXISTS(SELECT TOP 1 * FROM Majors WHERE MajorsCode = @MajorsCode))
			BEGIN
				SELECT N'Ngành không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		UPDATE Account SET PassWord = @PassWord, FullName = @FullName, Enable = @Enable, Type = @Type, Sex = @Sex, Birthday = @BirthDay, Address = @Address, MajorsCode = @MajorsCode WHERE AccountCode = @AccountCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Cập nhật tài khoản thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[UpdateClass]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[UpdateClass] @TeacherCode VARCHAR(20), @StartDate DATETIME, @EndDate DATETIME, @Enable INTEGER, @MaxGroup INTEGER, @HK INTEGER, @ThematicCode VARCHAR(20), @TimeRes DATETIME, @TimeGroup DATETIME
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@StartDate,'') = '' OR ISNULL(@TeacherCode,'') = '' OR ISNULL(@EndDate,'') = '' OR ISNULL(@Enable,'') = '' OR ISNULL(@MaxGroup,'') = '' OR ISNULL(@ThematicCode,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Thematic WHERE ThematicCode = @ThematicCode)
			BEGIN
				SELECT N'Chuyên đề không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@StartDate < @EndDate)
			BEGIN
				SELECT N'Ngày bắt đầu và kết thúc không hợp lệ' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@TimeRes < @StartDate OR @TimeRes > @EndDate)
			BEGIN
				SELECT N'Hạn đăng ký chuyên ngành từ ngày bắt đầu đến khi kết thúc chuyên đề' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@TimeGroup < @StartDate OR @TimeGroup > @EndDate)
			BEGIN
				SELECT N'Hạn đăng ký nhóm từ ngày bắt đầu đến khi kết thúc chuyên đề' Message
				ROLLBACK TRAN
				RETURN
			END
		UPDATE Class SET StartDate = @StartDate, EndDate = @EndDate, Enable = @Enable, MaxGroup = @MaxGroup, HK = @HK, TimeRes = @TimeRes, TimeGroup = @TimeGroup WHERE ThematicCode = @ThematicCode AND TeacherCode = @TeacherCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Cập nhật chuyên ngành thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[UpdateMajors]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[UpdateMajors] @MajorsCode VARCHAR(20), @MajorsName VARCHAR(200), @SuccessMaticNumber INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@MajorsCode,'') = '' OR ISNULL(@MajorsName,'') = '' OR ISNULL(@SuccessMaticNumber,'') = '')
			BEGIN
				SELECT N'Chưa nhập đầy đủ thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@SuccessMaticNumber >= 5 OR @SuccessMaticNumber < 0)
			BEGIN
				SELECT N'Số lượng chuyên đề hoàn thành từ 0 đến 5' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Majors WHERE MajorsCode = @MajorsCode)
			BEGIN
				SELECT N'Mã ngành không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT * FROM Majors WHERE MajorsName = @MajorsName AND MajorsCode != @MajorsCode)
			BEGIN
				SELECT N'Tên ngành đã tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		UPDATE Majors SET MajorsName = @MajorsName, SuccessMaticNumber = @SuccessMaticNumber WHERE MajorsCode = @MajorsCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Cập nhật ngành thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[UpdateRegistrationAVG]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[UpdateRegistrationAVG] @ClassID INTEGER, @AccountCode VARCHAR(20), @AVG INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@ClassID,'') = '' OR ISNULL(@AccountCode,'') = '' OR ISNULL(@AVG,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Registration WHERE ClassID = @ClassID AND AccountCode = @AccountCode)
			BEGIN
				SELECT N'Không tồn tại điểm sinh viên' Message
				ROLLBACK TRAN
				RETURN
			END
		UPDATE Registration SET AVG = @AVG WHERE ClassID = @ClassID AND AccountCode = @AccountCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Cập nhật điểm thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
/****** Object:  StoredProcedure [dbo].[UpdateThematic]    Script Date: 9/15/2018 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[UpdateThematic] @ThematicCode VARCHAR(20), @ThematicName VARCHAR(200), @SubjectsCode VARCHAR(20), @Enable INTEGER, @ThematicLimit INTEGER, @IsCompel INTEGER
AS
BEGIN TRAN
	BEGIN TRY
		IF(ISNULL(@ThematicCode,'') = '' OR ISNULL(@ThematicName,'') = '' OR ISNULL(@SubjectsCode,'') = '' OR ISNULL(@Enable,'') = ''  OR ISNULL(@ThematicLimit,'') = ''  OR ISNULL(@IsCompel,'') = '')
			BEGIN
				SELECT N'Kiểm tra lại thông tin' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@ThematicLimit <= 0)
			BEGIN
				SELECT N'Số lượng học sinh phải lớn hơn 0' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS (SELECT * FROM Thematic WHERE ThematicCode != @ThematicCode AND ThematicName = @ThematicName)
			BEGIN
				SELECT N'Chuyên đề đã tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF NOT EXISTS(SELECT TOP 1 * FROM Subjects WHERE SubjectsCode = @SubjectsCode AND Enable = 1)
			BEGIN
				SELECT N'Môn học không tồn tại' Message
				ROLLBACK TRAN
				RETURN
			END
		IF EXISTS(SELECT * FROM Subjects WHERE SubjectsCode = @SubjectsCode AND Enable = 0)
			BEGIN
				SELECT N'Bộ môn đã đóng' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@ThematicLimit < (SELECT AccountNumber FROM Class WHERE ThematicCode = @ThematicCode))
			BEGIN
				SELECT N'Không thể cập nhật số lượng học sinh đăng ký chuyên đề nhỏ hơn số lượng học sinh đang theo chuyên đề' Message
				ROLLBACK TRAN
				RETURN
			END
		IF(@ThematicLimit > (SELECT SubjectsLimit FROM Subjects WHERE SubjectsCode = @SubjectsCode))
			BEGIN
				SELECT N'Không thể cập nhật số lượng học sinh đăng ký chuyên đề lớn hơn số lượng học sinh bộ môn' Message
				ROLLBACK TRAN
				RETURN
			END
		UPDATE Thematic SET ThematicName = @ThematicName, SubjectsCode = @SubjectsCode, Enable = @Enable, ThematicLimit = @ThematicLimit, IsCompel = @IsCompel WHERE ThematicCode = @ThematicCode
		IF(@@ERROR != 0)
			BEGIN
				SELECT N'Không thực hiện được. Thử lại sau' Message
				ROLLBACK TRAN
				RETURN
			END
		SELECT N'Cập nhật chuyên ngành thành công' Message
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT N'Lỗi hệ thống' Message
		ROLLBACK TRAN
		RETURN
	END CATCH



GO
