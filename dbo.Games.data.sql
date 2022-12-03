SET IDENTITY_INSERT [dbo].[Games] ON
INSERT INTO [dbo].[Games] ([gameId], [gameTitle], [gameCategory], [gameRating]) VALUES (NULL, NULL, NULL, NULL)
INSERT INTO Games Values("Elden Ring", "Video Game", "M17")
INSERT INTO Games Values("Outer Wilds", "Video Game", "E")
INSERT INTO Games Values("Everdell", "TTRPG", "E")
INSERT INTO Games Values("DND", "TTRPG", "E")
SET IDENTITY_INSERT [dbo].[Games] OFF
