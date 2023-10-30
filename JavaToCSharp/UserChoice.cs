namespace JavaToCSharp;

public class UserChoice
{
    
    /*public static string UserName { get; set; }
    public string UserType { get; set; }
    public string UserSays { get; set; }*/

    public static ITalkable NewObject;
    
    public ITalkable UserObject()
    {
        string user1;
        string user2;

        bool isFriendly;
        int miceKilled;
        int teacherAge = 0;
        
        string user3;
        string user4;
        string user5;
        
        try
        {
            do
            {
                do
                {
                    Console.WriteLine("Hello! Will you be making a new Dog, Cat or Teacher? ");
                    user1 = Console.ReadLine();
                    //user1 = Validation();
                } while (String.IsNullOrWhiteSpace( user1 ) != false);
                
            } while (user1.ToLower() != "dog" && user1.ToLower() != "cat" && user1.ToLower() != "teacher");
            
            do
            {
                Console.WriteLine("What will you name it?");
                user2 = Console.ReadLine();
                //user2 = Validation();
            } while (String.IsNullOrWhiteSpace( user2 ) == true);

            switch (user1.ToLower())
            {
                case "dog":
                {
                    do
                    {
                        Console.WriteLine($"Is {user2} friendly?");
                        user3 = Console.ReadLine();
                        //user3 = Validation();
                    } while (String.IsNullOrWhiteSpace( user3 ) == true);

                    if (user3.ToLower() == "yes")
                    {
                        isFriendly = true;
                    }
                    else
                    {
                        isFriendly = false;
                    }

                    NewObject = new Dog(isFriendly, user2);
                    Console.WriteLine("Line 59 UserChoice " + NewObject.Talk());
                    break;
                }
                case "cat":
                {
                    do
                    {
                        Console.WriteLine($"How many mice has {user2} hunted? (1,2 etc...) ");
                        user4 = Console.ReadLine();
                    } while (String.IsNullOrWhiteSpace( user4 ) == true);

                    miceKilled = Convert.ToInt32(user4);
                    if (miceKilled < 0)
                    {
                        miceKilled = 0;
                    }

                    NewObject = new Cat(miceKilled, user2);
                    break;
                }
                case "teacher":
                {
                    Console.WriteLine("Teachers should at least 20 years old.");
                    do
                    {
                        do
                        {
                            Console.WriteLine($"How old is {user2}?");
                            user5 = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace( user5 ) == true);

                        teacherAge = Convert.ToInt32(user5);

                    } while (teacherAge <= 20);

                    NewObject = new Teacher(teacherAge, user2);
                    break;
                }
            }

            /*while (Validation() != "notvalid")
            {
                Console.WriteLine(Validation());
            }
            
            if (Validation() != "notvalid")
            {
                user1 = Validation();
            }
            else
            {
                
            }*/

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return NewObject;
    }
    
    public static string Validation()
    {
        string valid = "notvalid";
        string? response = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(response))
        {
            valid = $"{response}";
        }
        return valid;
    }
}