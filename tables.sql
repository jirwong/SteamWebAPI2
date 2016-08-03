SQL Scripts

create table SteamUser
(
	SteamID bigint NOT NULL PRIMARY KEY,
	Avatar varchar(50) NULL,
	AvatarFull varchar(50) NULL,
	AvatarMedium varchar(50) NULL,
	CustomURL varchar(50) NULL,
    Headline varchar(50) NULL,
    HoursPlayedLastTwoWeeks decimal NULL,
	sLimitedAccount varchar(5) NULL,
    sVacBanned varchar(5) NULL,
	Location varchar(50) NULL,
    MemberSince varchar(50) NULL,
    Nickname varchar(50) NULL,
    RealName varchar(50) NULL,
    State varchar(50) NULL,
    StateMessage varchar(50) NULL,
    SteamRating decimal(10,5) NULL, 
    Summary varchar(50) NULL,
    TradeBanState varchar(50) NULL,
    VisibilityState int NULL,
	ProfileCreatedDate datetime NOT NULL,
	ProfileLastUpdated datetime NOT NULL
)

Create Table SteamFriends
(
	SteamFriendID int IDENTITY(1,1) not null Primary Key,
	SteamID bigint NOT NULL,
	FriendID bigint NOT NULL,
	FriendSince datetime NOT NULL,
	Relationship varchar(50) NULL,
)
	
Create Table MostPlayedGames
(
	MostPlayedGamesID int IDENTITY(1,1) not null primary key,
    HoursOnRecord decimal NULL,
	HoursPlayed decimal NULL,
    Icon varchar(50) NULL,
    Link varchar(50) NULL,
    Logo varchar(50) NULL,
    LogoSmall varchar(50) NULL,
    Name varchar(50) NULL,
    StatsName varchar(50) NULL
)

Create Table SteamOwnedGames
(
	SteamOwnedGamesID int IDENTITY(1,1) not null primary key,
	AppId int NOT NULL,
	HasCommunityVisibleStats varchar(5) NULL,
	ImgIconUrl varchar(50) NULL,
	ImgLogoUrl varchar(50) NULL,
	Name varchar(50) NULL,
	Playtime2weeks int NULL,
	PlaytimeForever in NULL
)
	
-- WIP : To be completed later.
-- Create Table SteamGame
-- (
-- 	varchar(50) AppId 
-- )