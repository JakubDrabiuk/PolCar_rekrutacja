
SET IDENTITY_INSERT [dbo].[PracownikRola] ON 
GO
INSERT [dbo].[PracownikRola] ([PraRID], [PraR_Nazwa], [PraR_Opis]) VALUES (1, N'Pracownik', N'Podstawowa rola użytkownika')
GO
INSERT [dbo].[PracownikRola] ([PraRID], [PraR_Nazwa], [PraR_Opis]) VALUES (2, N'Menadżer', N'Menadzer - rola która ma większe uprawnienia')
GO
SET IDENTITY_INSERT [dbo].[PracownikRola] OFF
GO
SET IDENTITY_INSERT [dbo].[Pracownik] ON 
GO
INSERT [dbo].[Pracownik] ([PraID], [Pra_Nazwa], [Pra_PraRID], [Pra_Szef]) VALUES (2, N'Karol Wojtyła', 1, 4)
GO
INSERT [dbo].[Pracownik] ([PraID], [Pra_Nazwa], [Pra_PraRID], [Pra_Szef]) VALUES (3, N'Stefan Wyszyński', 1, 4)
GO
INSERT [dbo].[Pracownik] ([PraID], [Pra_Nazwa], [Pra_PraRID], [Pra_Szef]) VALUES (4, N'Jan Paweł II', 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[Pracownik] OFF
GO
