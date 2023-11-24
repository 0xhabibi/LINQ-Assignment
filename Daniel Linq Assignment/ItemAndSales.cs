namespace ItemsandSales
{
    public class Item
    {
        //Define properties for the Item Class
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }

    public class Sales
    {
        //Define properties for the Sales Class
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int Qty { get; set; }
    }

}