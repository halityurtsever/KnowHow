### Merge sort algorithm

Divide an unsorted list recursively until each list has only one element.
Then merge all divided list by producing a new sorted list.

Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4

Divide left array  -> 7 - 3 - 9 - 5 - 2   8 - 6 - 1 - 4
                      ^---------------^

Divide left array  -> 7 - 3 - 9   5 - 2   8 - 6 - 1 - 4
                      ^-------^   ^---^

Divide left array  -> 7 - 3   9   5   2   8 - 6 - 1 - 4
                      ^---^   ^   ^   ^

Divide left array  -> 7   3   9   5   2   8 - 6 - 1 - 4
                      ^   ^   ^   ^   ^

Merge left array   -> 3 - 7   9   5   2   8 - 6 - 1 - 4
                      ^---^   ^   ^   ^

Merge left array   -> 3 - 7 - 9   5   2   8 - 6 - 1 - 4
                      ^-------^   ^   ^

Merge left array   -> 3 - 7 - 9   2 - 5   8 - 6 - 1 - 4
                      ^-------^   ^---^

Merge left array   -> 2 - 3 - 5 - 7 - 9   8 - 6 - 1 - 4
                      ^---------------^

Divide right array -> 2 - 3 - 5 - 7 - 9   8 - 6   1 - 4
                                          ^---^   ^---^

Divide right array -> 2 - 3 - 5 - 7 - 9   8   6   1   4
                                          ^   ^   ^   ^

Merge right array  -> 2 - 3 - 5 - 7 - 9   6 - 8   1   4
                                          ^---^   ^   ^

Merge right array  -> 2 - 3 - 5 - 7 - 9   6 - 8   1 - 4
                                          ^---^   ^---^

Merge right array  -> 2 - 3 - 5 - 7 - 9   1 - 4 - 6 - 8
                                          ^-----------^

Merge all array    -> 2 - 3 - 5 - 7 - 9   1 - 4 - 6 - 8
                      ^---------------^   ^-----------^

Sorted array       -> 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9

Worst case performance: O(n log(n))
Best case performance: O(n log(n)) typical, O(n) natural variant
Average performance: O(n log(n))
Worst case space complexity: O(n) total, O(n) auxiliary