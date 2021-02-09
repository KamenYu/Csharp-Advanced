namespace BorderControl
{
    public interface IBuyer
    {
        public int Food { get; set; }
        public string Name { get; set; } // hm?
        public void BuyFood();        
    }
}
