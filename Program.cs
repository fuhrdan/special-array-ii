//*****************************************************************************
//** 3152. Special Array II                                         leetcode **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
bool* isArraySpecial(int* nums, int numsSize, int** queries, int queriesSize, int* queriesColSize, int* returnSize)
{
    int* d = (int*)malloc(numsSize * sizeof(int));
    for (int i = 0; i < numsSize; i++)
    {
        d[i] = i;
    }

    for (int i = 1; i < numsSize; i++)
    {
        if ((nums[i] % 2) != (nums[i - 1] % 2))
        {
            d[i] = d[i - 1];
        }
    }

    *returnSize = queriesSize;
    bool* ans = (bool*)malloc(queriesSize * sizeof(bool));

    for (int i = 0; i < queriesSize; i++)
    {
        int left = queries[i][0];
        int right = queries[i][1];
        ans[i] = (d[right] <= left);
    }

    free(d);

    return ans;
}