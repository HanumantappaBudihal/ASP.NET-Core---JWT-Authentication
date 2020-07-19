USE [Learning]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Name], [Category], [Color], [UnitPrice], [AvailableQuantity]) VALUES (1, N'MSI Laptop', N'Gaming', N'Red and White', CAST(200000 AS Decimal(18, 0)), 12)
INSERT [dbo].[Products] ([ProductId], [Name], [Category], [Color], [UnitPrice], [AvailableQuantity]) VALUES (2, N'Apple', N'Personal', N'Grey', CAST(120000 AS Decimal(18, 0)), 3)
INSERT [dbo].[Products] ([ProductId], [Name], [Category], [Color], [UnitPrice], [AvailableQuantity]) VALUES (3, N'Lamda X', N'Machine Learning', N'Black and White', CAST(300000 AS Decimal(18, 0)), 13)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
