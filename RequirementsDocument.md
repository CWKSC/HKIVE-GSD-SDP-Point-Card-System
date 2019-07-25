## Requirements Document 需求文檔 需求文档 

This is the school's request document

這是學校給出需求文檔。

这是学校给出需求文档。

___

### Project Scenario

#### Profile of the HKIVE Game Entertainment

HKIVE Game Entertainment is a local based game company in developing online games on
Android Mobile Phone Platform. Everyone can download the games from Google Play free of
charge. First time player needs to register when activate the game. However, players can buy tools
and weapons using virtual money issued by the company. The virtual money can be topped-up by
Point Card or by completing some designed tasks when playing the game. Different values of Point
Card sealed in plastic bag can be purchased from various convinces stores.

The company currently released two games, namely GSD War Zone and GSD F1 Race. GSD
War Zone is a 3D action shooting games on Android platforms. GSD F1 Race is a first person racing
game on Android platform. The company expects to release another three games in the coming year.
Players need to login to topped-up their virtual money through the company website. Each
Point Card has a unique ID and an activate code and each Point Card may worth 50, 100 and 200. If a
Point Card is not activated within three trails, the Point Card will be suspended and need to be
reinstated by the corresponding company staff manually.

#### Point Card Overview

HK$50 = 150 Virtual Gold Coins
HK$100 = 350 Virtual Gold Coins + one Lucky Draw
HK$200 = 800 Virtual Gold Coins + two Lucky Draw

When activating the Point Card, player gets a fixed number of chances to play the Lucky
Draw. The player need to guess a secret number is greater than five or not correctly. If the player
wins, he/she then has a chance to increase the values of the Virtual Gold Coins by 10%, 20%, 50% or
100%.

#### Mini game “Lucky Draw”

The game generates a random number between one and ten. The player needs to guess whether the
secret number is greater than number five or not. When the guessing is correct, the player will has a
lucky draw.

#### Chance of Increasing the Virtual Gold Coins

Chance of increasing 10% of topped-up Virtual Gold Coins is 0.5
Chance of increasing 20% of topped-up Virtual Gold Coins is 0.3
Chance of increasing 50% of topped-up Virtual Gold Coins is 0.15
Chance of increasing 100% of topped-up Virtual Gold Coins is 0.05

The new system should maintain player account and Point Card detail. Only assigned
company staff could create the Point Cards. Each Point Card have a unique ID (10 digits), an activate
password (6 alphanumeric) and a retail value. Player could top-up his/her account by inputting the



Point Card ID and activate password. The installed Mobile Games should connect to game server
(shared database) to access stored player information and his/her game progress to restore or save
player’s latest status whenever the game starts and ends. This Mobile Games functions are out of the
scope the current project.

The system should provide the following features to company staff:

1. Create Point Card (Customer Service Manager)
2. Enquire Point Card Detail
3. Maintain Point Card
4. Maintain Player Account
5. View Player Point Card topped-up History
6. Top-up Player account by Point Card (Customer Service Manager)

The system should provide the following features to players:

1. Enquire the Game Detail by Name
2. View Game Promotion and Point Card information
3. Register Player Account
4. Enquire Player Information and Game Progress
5. Top-up balance by Point Card
6. Play Mini game “Lucky Draw”

The about features are the basic requirement from HKIVE Game Entertainment, any enhanced
feature(s) that can increase the values of this project is/are welcome by the company.

#### Project Background

The management of HKIVE Game Entertainment out-sources this project to an IT firm
because the in-house development team is busy in developing the three coming games. Currently, the
games have their own game server (database) to store player’s information, which should be merged
with the newly design database. After the successful launch of the proposed system, the games will
connect to the new database every time player start the game. The company expected your company
to submit an Analysis and Design Report in Early-June and launch the applications in Early-July.
Assume your team have already conducted a meeting with the users and the records of the user
interview are as follow:

#### Record of User Interview

1. Customer Service Manager
  Single integrated player account for all games players is expected, but separate wallet for each
  mobile game (tools, weapons and status) that needed when start and end the game. New
  player need to register before using the new system. Registered player can enquiry his/her
  personal information and account status. A player can purchase the Point Cards from any
  nearby conveniences store in a prepacked from. Each Point Card can only top-up for one
  player account once with a successful activation. Only Customer Service Manager can
  generate new Point Cards that will sell in convenience stores. The generate Point Card UI
  should allow manager to input the quantity and retail value of the Point Card to be generated.
  New Point Cards list is then printed and sent to sales department for making the Point Card
  package. At the same time, newly generated Point Card information will add to database for
  player topped-up process. Furthermore, all CS staff need to login before using this system.
2. Customer Service Staff
   The proposed system should maintain all Player Accounts, Game Progress, Point Cards used.
   CS staff need to answer player’s query about his/her personal information and progress by
   entering correct account number. CS staff need to top-up any personal account by getting
   correct Point Card information from a player. CS staff also need to reinstated or suspend a
   Point Card when needed.

3. Game Developers (mobile game team)
Player account is formed by eight alphanumeric characters with a password is six to fifteen
alphanumeric characters. Detail newly designed table(s) structure is/are expected from your
analysis and design report because the games developer team have to amend the games for
connecting the new database.
4. Head of IT Department
The IT department will provide all hardware. The development platforms of the applications
are as follows:
Application platform C#.NET
Online Player webpage ASP.NET
All applications (include mobile games) share the same database developed by MS ACCESS
or other appropriate database tools approved by the IT Department (module lecturer). All staff
need to login to access the new system.
5. CEO
Our business is expanding in Hong Kong and is planning to enter the Greater China market.
The proposed system should support English, Traditional Chinese and Simplified Chinese as
an extra feature.