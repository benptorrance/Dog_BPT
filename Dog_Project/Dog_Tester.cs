using System;


namespace Dog_Project
{
    class Dog_Tester
    {
        static void Main(string[] args)
        {
			Dog dog = new Dog();

			Console.WriteLine("Please enter the dog's name:");
			dog.setName(Console.ReadLine());
			Console.WriteLine("Please enter the dog's age:");
			string input = Console.ReadLine();
			int num;
			if (int.TryParse(input, out num))
			{
				dog.setAge(num);
			}
			else
			{
				Console.WriteLine("Not a number. Please enter a number.");
			}

			int dog_age = dog.getAge();
			string dog_name = dog.getName();
			int dog_years = dog.calcDogYears();
			Console.WriteLine("Your dog's name is: " + dog_name + " and is " + dog_age + " years old.");
			Console.WriteLine("That's " + dog_years + " dog years.");
        }
    }

    public class Dog
    {
		private int age;
		private String name;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Dog()
		{
			age = 0;
			name = "";
		}//end constructor

		/**
		 * Constructor accepts the age and
		 * name of the dog. This is the preferred
		 * constructor.
		 * @param age
		 * @param name
		 */
		public Dog(int age, String name)
		{

			this.setAge(age);
			this.setName(name);

		}//end constructor

		public int calcDogYears()
		{
			int dogYears = 15 + (this.age - 1) * 7;
			return dogYears;
		}

		/**
		 * Getter for age
		 * @return
		 */
		public int getAge()
		{
			return age;
		}//end getAge

		/**
		 * Setter for age
		 * Checks the bounds so 
		 * @param age
		 */
		public void setAge(int age)
		{
			if (age < 0)
				this.age = 0;
			else
				this.age = age;
		}//end setAge

		/**
		 * Getter for name
		 * @return
		 */
		public String getName()
		{
			return name;
		}//end getName

		/**
		 * Setter for name. Ensures that only
		 * alpha characters are allowed in the name.
		 * @param name
		 */
		public void setName(String name)
		{
			bool valid = true;
			char[] n = name.ToCharArray();

			foreach (char c in n)
			{
				if (!char.IsLetter(c))
				{
					valid = false;
					break;
				}
			}

			if (valid)
				this.name = name;
			else
				this.name = "";

		}//end setName

	public String toString()
		{
			return "Dog [age=" + age + ", name=" + name + "]";
		}//end toString

	}
}
