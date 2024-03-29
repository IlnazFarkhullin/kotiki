USE [kotik]
GO
/****** Object:  Table [dbo].[info]    Script Date: 08.03.2023 14:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[info](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[image] [text] NULL,
 CONSTRAINT [PK_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[info] ON 

INSERT [dbo].[info] ([id], [name], [image]) VALUES (1, N'Барсик', N'/kotoki/barsik.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (2, N'Альф', N'/kotoki/alf.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (3, N'Анатолий', N'/kotoki/alf.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (4, N'Бруно', N'/kotoki/Bruno.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (5, N'Черныш', N'/kotoki/chernsh.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (6, N'Чижик', N'/kotoki/chijik.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (7, N'Годзилла', N'/kotoki/godzilla.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (8, N'Хопа', N'/kotoki/hopa.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (9, N'Миша', N'/kotoki/misha.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (10, N'Шрек', N'/kotoki/shrek.jpg')
INSERT [dbo].[info] ([id], [name], [image]) VALUES (11, N'Василий', N'/kotoki/vasiliy.jpg')
SET IDENTITY_INSERT [dbo].[info] OFF
GO
