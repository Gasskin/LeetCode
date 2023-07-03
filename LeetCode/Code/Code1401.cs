using System;

namespace LeetCode
{
    public class Code1401
    {
        public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
        {
            // 点是否在圆内（包括圆上
            bool IsInCycle(float x, float y)
            {
                return (x - xCenter) * (x - xCenter) + (y - yCenter) * (y - yCenter) <= radius * radius;
            }

            // 如果4个角在圆内，那么肯定相交
            if (IsInCycle(x1, y1) || IsInCycle(x1, y2) || IsInCycle(x2, y1) || IsInCycle(x2, y2))
            {
                return true;
            }

            // 圆在矩形内，圆心在矩形内，且半径小于圆心到四条边的值中的最小值
            if (x1 <= xCenter && xCenter <= x2 && y1 <= yCenter && yCenter <= y2)
            {
                var dis1 = Math.Abs(xCenter - x1);
                var dis2 = Math.Abs(xCenter - x2);
                var dis3 = Math.Abs(yCenter - y1);
                var dis4 = Math.Abs(yCenter - y2);
                if (radius <= dis1 && radius <= dis2 && radius <= dis3 && radius <= dis4)
                {
                    return true;
                }
            }

            // 最近的4个点，是否在圆内
            if (x1 <= xCenter && xCenter <= x2)
            {
                if (IsInCycle(xCenter, y1) || IsInCycle(xCenter, y2))
                    return true;
            }
            if (y1 <= yCenter && yCenter <= y2)
            {
                if (IsInCycle(x1, yCenter) || IsInCycle(x2, yCenter))
                    return true;
            }
           
            return false;
        }
    }
}