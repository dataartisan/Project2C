using System.Drawing;

//marker class implements icarriable
namespace Project2B
{
	class Marker: ICarriable
	{
		public static readonly Color _green = Color.FromName("Green");
		public static readonly Color _red = Color.FromName("Red");

		/// <summary>
		/// returns whether object is carriable.
		/// </summary>
	    public bool Carriable
	    {
            get { return true; }
	    }
	}
}
