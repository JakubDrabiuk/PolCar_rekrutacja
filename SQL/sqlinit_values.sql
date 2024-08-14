
SET IDENTITY_INSERT [dbo].[PracownikRola] ON 
GO
INSERT [dbo].[PracownikRola] ([PraRID], [PraR_Nazwa], [PraR_Opis]) VALUES (1, N'Pracownik', N'Podstawowa rola użytkownika')
GO
INSERT [dbo].[PracownikRola] ([PraRID], [PraR_Nazwa], [PraR_Opis]) VALUES (2, N'Menadżer', N'Menadzer - rola która ma większe uprawnienia')
GO
SET IDENTITY_INSERT [dbo].[PracownikRola] OFF
GO
SET IDENTITY_INSERT [dbo].[Priorytet] ON 
GO
INSERT [dbo].[Priorytet] ([PriID], [Pri_Nazwa], [Pri_Opis]) VALUES (0, N'Brak priorytetu', N'podstawowy priorytet,wszystkie nie udostepnione zadania są bez priorytetu')
GO
INSERT [dbo].[Priorytet] ([PriID], [Pri_Nazwa], [Pri_Opis]) VALUES (1, N'Mało Pilne', N'zadanie o małym priorytecie')
GO
INSERT [dbo].[Priorytet] ([PriID], [Pri_Nazwa], [Pri_Opis]) VALUES (2, N'Pilne', N'Zadanie które nalezy wykonać w przeciągu 2 tyg')
GO
INSERT [dbo].[Priorytet] ([PriID], [Pri_Nazwa], [Pri_Opis]) VALUES (3, N'Bardzo Pilne ', N'Zadanie które trzeba wykonać w mniej niż 1 tydzień ')
GO
INSERT [dbo].[Priorytet] ([PriID], [Pri_Nazwa], [Pri_Opis]) VALUES (4, N'Super-duper Pilne ', N'Należy zostawić WSZYSTKIE ZADANIA i zająć się tym')
GO
INSERT [dbo].[Priorytet] ([PriID], [Pri_Nazwa], [Pri_Opis]) VALUES (5, N'APOKALIPSA', N'Należy zrobic to na wczoraj')
GO
SET IDENTITY_INSERT [dbo].[Priorytet] OFF
GO
SET IDENTITY_INSERT [dbo].[ZadaniaStatus] ON 
GO
INSERT [dbo].[ZadaniaStatus] ([ZadStID], [ZadSt_Nazwa], [ZadSt_Opis]) VALUES (1, N'Utworzone', N'Podstawowy status dla zadań, z tym statusem zadania nie są udostepnione')
GO
INSERT [dbo].[ZadaniaStatus] ([ZadStID], [ZadSt_Nazwa], [ZadSt_Opis]) VALUES (2, N'Planowanie', N'Pierwszy etap wykonania zadania')
GO
INSERT [dbo].[ZadaniaStatus] ([ZadStID], [ZadSt_Nazwa], [ZadSt_Opis]) VALUES (3, N'Działanie', N'Statu który reprezentue aktywną pracę nad zadaniem w danym momencie')
GO
INSERT [dbo].[ZadaniaStatus] ([ZadStID], [ZadSt_Nazwa], [ZadSt_Opis]) VALUES (4, N'Wykonane', N'Status po wykonaniu zadania')
GO
INSERT [dbo].[ZadaniaStatus] ([ZadStID], [ZadSt_Nazwa], [ZadSt_Opis]) VALUES (5, N'Zakończone', N'Zakończone zadanie, tylko menedze może zakończyć zadanie')
GO
SET IDENTITY_INSERT [dbo].[ZadaniaStatus] OFF
GO
