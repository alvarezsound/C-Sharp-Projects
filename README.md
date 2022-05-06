# C# Projects
This is the repository for all of my C# and .NET course projects! Click the links below to view the files.
## Projects:
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/CarInsurance" target="_blank">Car Insurance Quotes</a>
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/NewsletterAppMVC" target="_blank">Newsletter Sign-up</a>
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/TwentyOne" target="_blank">Twenty One Game</a>
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/C_Sharp_Challenges" target="_blank">C# Challenges</a>
- <a href="https://github.com/alvarezsound/C-Sharp-Projects/tree/main/C_Sharp_Exercises" target="_blank">C# Exercises</a>
## Car Insurance Quotes
This app is an ASP.NET MVC web App that calculates a car insurance quote based on information provided by the user. ADO.NET Entity Data Model was used to create the Insuree data model used in the application and Bootstrap was used for basic styling. This app contains a Home Controller, Admin Controller, and an Insuree Controller along with corresponding views to render information to the user. The Admin view passes in a view model to limit the information sent to the Admin while the Admin Controller contains methods view to display all quotes that have been issued and stored in the database. The Insuree Controller contains a GetQuote method that calculates a monthly quote based on user-provided information passed in through a form on the webpage. Once the quote has been calculated, the quote is displayed to the user via the Insuree details view.

InsureeController.cs GetQuote method:
```cs
// Calculates Insurance Quote based on information passed in from form
        public ActionResult GetQuote(int Id)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = db.Insurees.Find(Id);

                decimal baseQuote = 50.00m; // base rate of $50.00

                // calculate age
                DateTime today = DateTime.Now; // current date
                var age = today.Subtract(insuree.DateOfBirth).TotalDays; // calculate age in # of days
                int ageInYears = Convert.ToInt32(age / 365); //calculate age in years

                // calculate additional monthly cost based on age
                if (ageInYears <= 18)
                {
                    baseQuote += 100; // add $100 if insuree < 18
                }
                else if (ageInYears >= 19 && ageInYears <= 25)
                {
                    baseQuote += 50; // add $50 to baseQuote if insuree age is between 19-25
                }
                else
                {
                    baseQuote += 25; // add $25 to baseQuote if insuree age > 25
                }

                // if CarYear is before year 2000 or after 2015, add $25 to baseQuote
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    baseQuote += 25;
                }

                // if CarMake is a Porcsche add $25 to baseQuote
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    baseQuote += 25;
                    // if CarModel is 911 Carrera add $25 to baseQuote
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        baseQuote += 25;
                    }
                }

                // calcuate additional monthly cost based on # of speeding tickets
                if (insuree.SpeedingTickets > 0)
                {
                    // add $10 for each speeding ticket to baseQuote
                    baseQuote += (insuree.SpeedingTickets * 10);
                }

                if (insuree.DUI) // insuree has a DUI
                {
                    baseQuote += (baseQuote * .25m); // add 25 % to baseQuote
                }

                // Insuree is requesting full coverage
                if (insuree.CoverageType)
                {
                    baseQuote += (baseQuote * .5m);
                }

                insuree.Quote = baseQuote; // finalized quote
                db.SaveChanges();
                return RedirectToAction("Details", new { Id = insuree.Id });
            }
        }
```
![Get Quote Insert](/Images/CarInsurance_1.png)

![Get Quote Results](/Images/CarInsurance_2.png)
## Twenty One Game
This is a basic console app built in the .NET Framework that creates a Twenty One card game. It utilizes namespaces, classes, and inheritance in a way that would allow the app to be expanded to other Casino-style games. Included classes: Card, Dealer, Deck, Player, Game, and a Fraud Exception class to alert Casino security when fraudulent activity is detected. Additionally, the following classes utilize inheritance :TwentyOneDealer inherits from Dealer and TwentyOneGame inherits from Game. The TwentyOneRules class is used to define the rules of TwentyOne and includes methods that determine if a player/dealer has busted, if the dealer should hit or stay, or if either has Blackjack.
## Newsletter Sign-up
This is simple ASP.NET MVC web app used to get and keep track of newsletter signups. ADO.NET is used to send/retrieve information to/from the Newsletter SQL database. There is an Admin and Home controller along with corresponding views to render the information to the user using Bootstrap styling. The Home view uses a simple form to collect signup information from the user, and the Home Controller SignUp method stores this informatin in a database. The Admin view passes in a viewmodel as a list to limit information sent directly to the Admin page. The Admin Controller contains a function to retrieve user information from the database and an unsubscribe function to update the database that a user has unsubscribed from the newsletter.
## C# Challenges
Using Visual Studio, I was given various challenges to create and code small programs from scratch using knowledge gained in the course and further research.
## C# Exercises
Various assignments and exercises used to build familiarity with C#.