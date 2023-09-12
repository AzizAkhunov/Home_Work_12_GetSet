namespace Home_Work_12_GetSet
{
    public class GetSet
    {
        public string Name { get; set; } = Console.ReadLine();
        public int Age { get; set; } = int.Parse(Console.ReadLine());

        public void NameAgeVerification()
        {
            if (Name.Length <= 4 || Age <= 18)
            {
                Console.WriteLine("Name and Age verified");
            }
            else
            {
                Console.WriteLine("Name and Age not verified!!");
            }
        }
    }
}
