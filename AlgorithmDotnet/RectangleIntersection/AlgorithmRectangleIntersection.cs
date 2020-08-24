namespace AlgorithmDotnet.RectangleIntersection
{
    public class Rectangle
    {
        public int LeftX { get; set; }
        public int RightX { get; set; }
        public int BottomY { get; set; }
        public int TopY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(int leftX, int bottomY, int width, int height)
        {
            LeftX = leftX;
            BottomY = bottomY;
            Width = width;
            Height = height;
            RightX = leftX + width;
            TopY = BottomY + height;
        }
    }

    public class AlgorithmRectangleIntersection
    {
        public Rectangle RectangleIntersection(Rectangle recFirst, Rectangle recSecond)
        {
            var resultRectangle = new Rectangle();

            recFirst.RightX = recFirst.LeftX + recFirst.Width;
            recFirst.TopY = recFirst.BottomY + recFirst.Height;
            recSecond.RightX = recSecond.LeftX + recSecond.Width;
            recSecond.TopY = recSecond.BottomY + recSecond.Height;

            if(recFirst.LeftX <= recSecond.LeftX)
            {
                resultRectangle.LeftX = recSecond.LeftX;
            }
            else
            {
                resultRectangle.LeftX = recFirst.LeftX;
            }

            if (recFirst.RightX <= recSecond.RightX)
            {
                resultRectangle.RightX = recFirst.RightX;
            }
            else
            {
                resultRectangle.RightX = recSecond.RightX;
            }

            resultRectangle.Width = resultRectangle.RightX - resultRectangle.LeftX;

            // Y
            if (recFirst.BottomY <= recSecond.BottomY)
            {
                resultRectangle.BottomY = recSecond.BottomY;
            }
            else
            {
                resultRectangle.BottomY = recFirst.BottomY;
            }

            if (recFirst.TopY <= recSecond.TopY)
            {
                resultRectangle.TopY = recFirst.TopY;
            }
            else
            {
                resultRectangle.TopY = recSecond.TopY;
            }

            resultRectangle.Height = resultRectangle.TopY - resultRectangle.BottomY;

            return resultRectangle;
        }
    }
}
