int[] height = { 1, 2, 4, 3 };

MaxArea(height);

int MaxAreaO(int[] height)
    {
    int left = 0, right = height.Length - 1, maxArea = 0, maxHeight = 0;
    while (left < right)
    {
        var leftHeight = height[left];
        if (leftHeight <= maxHeight)
        {
            left++;
            continue;
        }

        var rightHeight = height[right];
        if (rightHeight <= maxHeight)
        {
            right--;
            continue;
        }

        maxHeight = leftHeight < rightHeight
            ? leftHeight
            : rightHeight;

        var area = maxHeight * (right - left);
        if (maxArea < area)
            maxArea = area;
    }

    return maxArea;
}
int MaxArea(int[] height)
{
    int area = 0, a, b, l, r;
    int i = 0, j = height.Length-1, maxHeight = 0;

    while (j > i)
    {
        l = height[i];
        if (l < maxHeight)
        {
            i++;
            continue;
        }

        r = height[j];
        if (r < maxHeight)
        {
            j--;
            continue;
        }

        a = j - i;

        if (l > r)
        {
            b = height[j];

            if(a * b > area)
                area = a * b;

            maxHeight = r;
            j--;
        }
        else
        {
            b = height[i];

            if (a * b > area)
                area = a * b;

            maxHeight = l;
            i++;
        }
    }

    return area;
}
int MaxArea1(int[] height)
{
    int area = 0, a, b;
    int i = 0, j = height.Length - 1;

    while (j > i)
    {
        a = j - i;

        if (height[i] > height[j])
        {
            b = height[j];

            if (a * b > area)
                area = a * b;
            j--;
        }
        else
        {
            b = height[i];

            if (a * b > area)
                area = a * b;
            i++;
        }
    }

    return area;
}
