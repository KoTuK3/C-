namespace L04_Task01
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname} {Number}";
        }
    }
}