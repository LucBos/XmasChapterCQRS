USE [QFappStore]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/20/2012 07:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[InPromotion] [bit] NOT NULL,
	[PromotionPrice] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [InPromotion], [PromotionPrice]) VALUES (N'88f4808c-6688-4776-94d8-0ceefbdf942e', N'FartApp', N'Proin nec augue. Quisque aliquam http://thejoysofcode.com/post/37288948101/when-removing-a-comment-fixes-the-bug-that-your-team  tempor magna. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.', CAST(300 AS Decimal(18, 0)), 1, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [InPromotion], [PromotionPrice]) VALUES (N'd31257ec-6b85-468c-bb50-6173fdf42ebf', N'Q8 Locator', N'Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin semper, ante vitae sollicitudin posuere, metus quam iaculis nibh, vitae scelerisque nunc massa eget pede. Sed velit urna, interdum vel, ultricies vel, faucibus at, quam.', CAST(500 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [InPromotion], [PromotionPrice]) VALUES (N'e293c692-d4fc-42cf-b40f-62df362ca081', N'JoysOfCode', N'http://thejoysofcode.com/post/36931735251/when-marketing-tries-to-use-technical-terms', CAST(150 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [InPromotion], [PromotionPrice]) VALUES (N'762da58f-eae6-467b-bccd-a3e3cec93f7b', N'Calorator', N'Duis a quam non neque lobortis malesuada. Praesent euismod. Donec nulla augue, venenatis scelerisque, dapibus a, consequat at, leo.', CAST(150 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [InPromotion], [PromotionPrice]) VALUES (N'c41bed46-4270-4b3c-9ce4-b4c90d2fa7be', N'VTM app', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Luc is ne knappe vent. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', CAST(200 AS Decimal(18, 0)), 0, CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [InPromotion], [PromotionPrice]) VALUES (N'90e1c257-06e3-4f35-83af-bd26c374f11d', N'High card game', N'Donec blandit feugiat ligula. Donec hendrerit, felis et imperdiet euismod, purus ipsum pretium metus, in lacinia nulla nisl eget sapien. Donec ut est in lectus consequat consequat.', CAST(20 AS Decimal(18, 0)), 1, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [InPromotion], [PromotionPrice]) VALUES (N'e0127ba1-c71a-48ce-a02d-f02a9ede1321', N'Tomas koek', N'Ons moeder was ne goeie parochioan De paster die klopte dor doagelijks oan Mor op ene kier toen kwam em nie mier Ons moeder die was zwanger en da was geen eer Joa ik zin de zeun van meneer pastoor Ik zing altijd mee in et kaarekkoor Ik moak geen kabaal, kgo rond me de schoal Ik zin ekik den braafste van allemoal', CAST(50 AS Decimal(18, 0)), 1, CAST(20 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[Person]    Script Date: 12/20/2012 07:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Age] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Person] ([Id], [Name], [FirstName], [Address], [Age]) VALUES (N'63a71968-7479-42fd-b8ca-6449ee33fbef', N'Luc', N'Bos', N'Jezuietenlaan 42 Wilrijk', 25)
INSERT [dbo].[Person] ([Id], [Name], [FirstName], [Address], [Age]) VALUES (N'762da58f-eae6-467b-bccd-a3e3cec93f7b', N'Danny', N'Gladines', N'Veldkant 33b Kontich', 100)
/****** Object:  Table [dbo].[Review]    Script Date: 12/20/2012 07:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[Id] [uniqueidentifier] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[PersonId] [uniqueidentifier] NOT NULL,
	[NrOfStars] [int] NOT NULL,
	[Comment] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Review] ([Id], [ProductId], [PersonId], [NrOfStars], [Comment]) VALUES (N'e0def3e5-59e2-4078-b530-559e24843d27', N'88f4808c-6688-4776-94d8-0ceefbdf942e', N'63a71968-7479-42fd-b8ca-6449ee33fbef', 5, N'People think it''s the app making the noise!')
INSERT [dbo].[Review] ([Id], [ProductId], [PersonId], [NrOfStars], [Comment]) VALUES (N'7b98df99-f2aa-4871-bf88-6f98aac13e6c', N'88f4808c-6688-4776-94d8-0ceefbdf942e', N'762da58f-eae6-467b-bccd-a3e3cec93f7b', 5, N'Best app ever!')
INSERT [dbo].[Review] ([Id], [ProductId], [PersonId], [NrOfStars], [Comment]) VALUES (N'adb8c8e7-3a8d-4a6c-be7e-be44aa79ed83', N'90e1c257-06e3-4f35-83af-bd26c374f11d', N'762da58f-eae6-467b-bccd-a3e3cec93f7b', 4, N'People think I''m working but I''m just playing this game all day long!')
INSERT [dbo].[Review] ([Id], [ProductId], [PersonId], [NrOfStars], [Comment]) VALUES (N'f646e853-206a-488a-b959-bf147a217e0c', N'e0127ba1-c71a-48ce-a02d-f02a9ede1321', N'63a71968-7479-42fd-b8ca-6449ee33fbef', 3, N'I think you spelled the name wrong.')
INSERT [dbo].[Review] ([Id], [ProductId], [PersonId], [NrOfStars], [Comment]) VALUES (N'4239fb4b-ee30-4139-b5f4-c520e356ea2b', N'e0127ba1-c71a-48ce-a02d-f02a9ede1321', N'762da58f-eae6-467b-bccd-a3e3cec93f7b', 4, N'Finally, going to Greece! Μπορείτε ροκ luc!')
/****** Object:  Table [dbo].[Order]    Script Date: 12/20/2012 07:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [uniqueidentifier] NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[IsOrdered] [bit] NOT NULL,
	[PersonId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Order] ([Id], [OrderDate], [IsOrdered], [PersonId]) VALUES (N'b6ac03f7-873e-426d-831b-76df565a8ddb', CAST(0x07000000000064350B AS DateTime2), 1, N'63a71968-7479-42fd-b8ca-6449ee33fbef')
/****** Object:  View [dbo].[ReviewsWithPersonName]    Script Date: 12/20/2012 07:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ReviewsWithPersonName]
AS
SELECT     r.Id, p.FirstName, r.NrOfStars, r.Comment
FROM         dbo.Review AS r INNER JOIN
                      dbo.Person AS p ON r.PersonId = p.Id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "r"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ReviewsWithPersonName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ReviewsWithPersonName'
GO
/****** Object:  Table [dbo].[OrderLine]    Script Date: 12/20/2012 07:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLine](
	[Id] [uniqueidentifier] NOT NULL,
	[PriceWhenOrdered] [decimal](18, 0) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_OrderLine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[OrderLine] ([Id], [PriceWhenOrdered], [Quantity], [ProductId], [OrderId]) VALUES (N'4e1ea79a-08a3-4d8f-b257-fed6f547cef5', CAST(100 AS Decimal(18, 0)), 1, N'88f4808c-6688-4776-94d8-0ceefbdf942e', N'b6ac03f7-873e-426d-831b-76df565a8ddb')
/****** Object:  Default [DF_Order_IsOrdered]    Script Date: 12/20/2012 07:05:48 ******/
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_IsOrdered]  DEFAULT ((0)) FOR [IsOrdered]
GO
/****** Object:  Default [DF_Product_InPromotion]    Script Date: 12/20/2012 07:05:48 ******/
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_InPromotion]  DEFAULT ((0)) FOR [InPromotion]
GO
/****** Object:  ForeignKey [FK_Order_Person]    Script Date: 12/20/2012 07:05:48 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Person]
GO
/****** Object:  ForeignKey [FK_OrderLine_Order]    Script Date: 12/20/2012 07:05:48 ******/
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Order]
GO
/****** Object:  ForeignKey [FK_OrderLine_Product]    Script Date: 12/20/2012 07:05:48 ******/
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Product]
GO
/****** Object:  ForeignKey [FK_Review_Person]    Script Date: 12/20/2012 07:05:48 ******/
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Person]
GO
/****** Object:  ForeignKey [FK_Review_Product]    Script Date: 12/20/2012 07:05:48 ******/
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Product]
GO
