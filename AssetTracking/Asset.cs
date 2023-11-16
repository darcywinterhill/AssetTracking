namespace AssetTracking
{
    abstract internal class Asset
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }

        public abstract void AddedMessage();
        public abstract void Print();
        public abstract bool IsEndOfLifeNear();
        public abstract bool IsEndOfLifeAlmostNear();
    }

}
