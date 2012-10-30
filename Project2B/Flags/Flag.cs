namespace Project2B
{
    //these are the flags that are being used.
    public class Flag
    {
        /// <summary>
		/// Constructor
		/// </summary>
        public Flag()
        {
            RedFlag = false;
            GreenFlag = false;
            Left = false;
            Enter = false;
        }

        /// <summary>
		/// Autoimplemented properties
		/// </summary>
        public bool Enter { get; set; }

        public bool Left { get; set; }

        public bool GreenFlag { get; set; }

        public bool RedFlag { get; set; }
    }
}
