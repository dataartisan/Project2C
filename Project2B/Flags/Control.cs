//Class Control sets flag to true and returns the flags.
namespace Project2B
{
    internal class Control
    {
        private bool _flag = true;
		/// <summary>
		/// flag value gets changed to true
		/// </summary>
        public bool Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
		/// <summary>
		/// count method. auto-implemented
		/// </summary>
        public int Count { get; set; }
    }
}