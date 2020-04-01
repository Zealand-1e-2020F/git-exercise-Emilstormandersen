namespace GitExercise
{
    class myClass
    {
    
    private string _name;
    private string _adress;
    private int _phoneNumber;

    public myClass(string name, string adress, int phoneNumber)
    {
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;

    }

        public int PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public string Name { get => _name; set => _name = value; }

        public string GetInfo()
    {
        return "Myclass hedder " + Name + " og adressen er " + Adress + " telefonnumeret er " + PhoneNumber;
    }



    }
}