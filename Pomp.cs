using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aquarium
{
	class Pomp
	{
		private Random random;
		private Point left, right;
		private List<Point> points = new List<Point>();
		private int count;
		public int Pause { get; set; } = 15;
		public Pomp(Control back, Random random, Point left, Point right)
		{
			this.random = random;
			this.left = left;
			this.right = right;

			back.Paint += (s, e) => {
				foreach(Point point in points)
					e.Graphics.FillEllipse(Brushes.Azure, point.X, point.Y, 7, 7);
			};
		}
		public void Move()
		{
			for (int i = 0; i < points.Count; ++i)
			{
				Point point = points[i];
				if (point.Y < 0)
					points.RemoveAt(i--);
				else
					points[i] = new Point(point.X, point.Y - 1);
			}
			if (++count == Pause)
			{
				count = 0;
				points.Add(new Point(random.Next(left.X, right.X + 1), random.Next(left.Y, right.Y + 1)));
			}
		}
	}
}
