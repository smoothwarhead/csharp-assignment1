using System;

namespace assignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // declaring all the variables
            int age, ownerID, numberOfWeeks, FINISH, price, fee;
            String dogName, dogBreed;
            double dogWeight;

            // assign a value to finish, so that when the program get this value it stops.
            FINISH = 0;

            Console.WriteLine("This program continuously accepts dogs' data and displays billing data for each dog");
            Console.WriteLine("Enter the owner's ID number");

            // get the owner id from the user then convert it to an integer
            ownerID = Convert.ToInt32(Console.ReadLine());


            // as long as the owner id is not equal to finish which is 0, the the program will keep execute.
            while (ownerID != FINISH)
            {
                // get variables from the user
                Console.WriteLine("Enter the dog name");
                dogName = Console.ReadLine();

                Console.WriteLine("Enter the dog breed");
                dogBreed = Console.ReadLine();

                Console.WriteLine("Enter the dog's age");
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number of weeks the dog will be cared for");
            
                // get the number of weeks from the user then convert it to an integer
                numberOfWeeks = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the dog's weight");

                // get the number of weeks from the user then convert it to a real number
                dogWeight = Convert.ToDouble(Console.ReadLine());


                if(dogWeight < 15){
                    price = 55;

                    // get the day care fee by calling the function which calculates the fee.
                    fee = getCost(numberOfWeeks, price);

                    // call the function that decides if the fee is greater than 125 so that the owwner get a 2% discount.
                    isGreaterThan(fee, ownerID, dogName, dogBreed, age, numberOfWeeks, dogWeight);

                }
                else{
                    if(dogWeight >= 15 || dogWeight <= 30){
                        price = 75;

                        // get the day care fee by calling the function which calculates the fee.
                        fee = getCost(numberOfWeeks, price);

                        // call the function that decides if the fee is greater than 125 so that the owwner get a 2% discount.
                        isGreaterThan(fee, ownerID, dogName, dogBreed, age, numberOfWeeks, dogWeight);
                    }
                    else{
                        if(dogWeight >= 31 || dogWeight <= 80){
                            price = 105;

                            // get the day care fee by calling the function which calculates the fee.
                            fee = getCost(numberOfWeeks, price);

                            // call the function that decides if the fee is greater than 125 so that the owwner get a 2% discount.
                            isGreaterThan(fee, ownerID, dogName, dogBreed, age, numberOfWeeks, dogWeight); 
                        }
                        else{
                            if(dogWeight >= 80){
                                price = 125;

                                // get the day care fee by calling the function which calculates the fee.
                                fee = getCost(numberOfWeeks, price);

                            // call the function that decides if the fee is greater than 125 so that the owwner get a 2% discount.
                                isGreaterThan(fee, ownerID, dogName, dogBreed, age, numberOfWeeks, dogWeight);
                            }
                        }

            
                    }
                }

                Console.WriteLine($"Enter owner's ID number or {FINISH} to finish >>>");
                ownerID = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("No more data to be entered");


        }


        // creating a function that calculate the fee
        public static int getCost(int numberOfWeeks, int price )
        {
            int cost = numberOfWeeks * price;
             return cost;
        }

        

        // this function display the bill data if the customer gets a discount.
        public static void discountedOutput(int ownerID, String dogName, String dogBreed, int age, int numberOfWeeks, double dogWeight, double discountedFee)
        {
                Console.WriteLine($"Owner's ID number is {ownerID}");
                Console.WriteLine($"The dog name is {dogName}");
                Console.WriteLine($"Dog is a {dogBreed} breed");
                Console.WriteLine($"The dog is {age} years old");
                Console.WriteLine($"The dog will need {numberOfWeeks} weeek/s of care");
                Console.WriteLine($"Dog weight is {dogWeight} lbs");
                Console.WriteLine($"The Total day care fee is ${discountedFee}");

        }


         // creating a function that calculate the discounted fee
        public static double discountFee(int fee)
        {
            double disFee, rate;

            rate = 0.2 * fee;

            // calculate the discounted fee
            disFee = fee - rate;

            // return the discounted fee to be reused in the program
            return disFee;
        }


        // this function display the bill data.
        public static void displayOutput(int ownerID, String dogName, String dogBreed, int age, int numberOfWeeks, double dogWeight, int fee)
        {
                Console.WriteLine($"Owner's ID number is {ownerID}");
                Console.WriteLine($"The dog name is {dogName}");
                Console.WriteLine($"Dog is {dogBreed} breed");
                Console.WriteLine($"The dog is {age} years old");
                Console.WriteLine($"The dog will need {numberOfWeeks} weeek/s of care");
                Console.WriteLine($"Dog weight is {dogWeight} lbs");
                Console.WriteLine($"The total day care fee is ${fee}");

        }
        

        // this function display different outcomes if fee is greater than $125
        public static void isGreaterThan(int fee, int ownerID, String dogName, String dogBreed, int age, int numberOfWeeks, double dogWeight)
        {
            double discountedFee;

            if(fee > 125){
                Console.WriteLine("2% discount will be applied to your overall bill");

                // get the discounted fee by calling the discountFee function
                discountedFee = discountFee(fee);

                //call the discountedOutput function to display the bill data including the discounted fee
               discountedOutput(ownerID, dogName, dogBreed, age, numberOfWeeks, dogWeight, discountedFee);

            }

            else{

                //call the discountedOutput function to display the bill data including the fee
                displayOutput(ownerID, dogName, dogBreed, age, numberOfWeeks, dogWeight, fee);
            }
        }


    }
}


