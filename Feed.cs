using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aquarium
{
	class Feed : IDisposable
	{
		private Control back;
		private Point[] points = new Point[9];
		public Point Location => points[0];
		public int Side { get; set; } = 20;
		public bool IsAvailable => Location.Y < back.ClientSize.Height;
		public Feed(Control back, Random random)
		{
			this.back = back;
			points[0] = new Point(random.Next(back.ClientSize.Width - Side), 0);
			for (int i = 1; i < points.Length; ++i)
				points[i] = new Point(random.Next(Location.X, Location.X + Side), random.Next(Side));

			back.Paint += Back_Paint;
		}

		private void Back_Paint(object sender, PaintEventArgs e)
		{
			for (int i = 1; i < points.Length; ++i)
				e.Graphics.FillEllipse(Brushes.Orange, points[i].X, points[i].Y, 7, 7);
		}
		public void Move()
		{
			for (int i = 0; i < points.Length; ++i)
				++points[i].Y;
		}
		public void Dispose()
		{
			back.Paint -= Back_Paint;
		}
	}
}
