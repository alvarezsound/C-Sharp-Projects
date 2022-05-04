# C# Projects
This is the repository for all of my C# and .NET course projects!
## Projects:
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/CarInsurance" target="_blank">Car Insurance Quotes</a>
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/NewsletterAppMVC" target="_blank">Newsletter Sign-up</a>
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/TwentyOne" target="_blank">Twenty One Game</a>
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/C_Sharp_Challenges" target="_blank">C# Challenges</a>
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/C_Sharp_Exercises" target="_blank">C# Exercises</a>
## Car Insurance Quotes
This app is an ASP.NET MVC web App that calculates a car insurance quote based on information provided by the user. ADO.NET Entity Data Model was used to create the Insuree data model used in the application and Bootstrap was used for basic styling. This app contains a Home Controller, Admin Controller, and an Insuree Controller along with corresponding views to render information to the user. The Admin view passe in a view model to limit the information sent to the Admin while the Admin Controller contains methods view to display all quotes that have been issued and stored in the database. The Insuree Controller contains a GetQuote method that calculates a monthly quote based on user-provided information passed in through a form on the webpage. Once the quote has been calculated, the quote is displayed to the user via the Insuree details view.
## Twenty One Game
This is a basic console app built in the .NET Framework that creates a Twenty One card game. It utilizes namespaces, classes, and inheritance in a way that would allow the app to be expanded to other Casino-style games. Included classes: Card, Dealer, Deck, Player, Game, and a Fraud Exception class to alert Casino security when fraudulent activity is detected. Additionally, the following classes utilize inheritance :TwentyOneDealer inherits from Dealer and TwentyOneGame inherits from Game. The TwentyOneRules class is used to define the rules of TwentyOne and includes methods that determine if a player/dealer has busted, if the dealer should hit or stay, or if either has Blackjack.
## Newsletter Sign-up
This is simple ASP.NET MVC web app used to get and keep track of newsletter signups. ADO.NET is used to send/retrieve information to/from the Newsletter SQL database. There is an Admin and Home controller along with corresponding views to render the information to the user using Bootstrap styling. The Home view uses a simple form to collect signup information from the user, and the Home Controller SignUp method stores this informatin in a database. The Admin view passes in a viewmodel as a list to limit information sent directly to the Admin page. The Admin Controller contains a function to retrieve user information from the database and an unsubscribe function to update the database that a user has unsubscribed from the newsletter.
## C# Challenges
Using Visual Studio, I was given various challenges to create and code small programs from scratch using knowledge gained in the course and further research.
## C# Exercises
Various assignments and exercises used to build familiarity with C#.