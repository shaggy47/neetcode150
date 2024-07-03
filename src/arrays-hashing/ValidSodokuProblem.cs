using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_hashing
{
    public class ValidSodokuProblem
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rowSet = new Dictionary<int, HashSet<int>>();
            var colSet = new Dictionary<int, HashSet<int>>();
            var sub3Set = new Dictionary<int, HashSet<int>>();

            for (int r = 0; r < 9; r++)
            {
                rowSet.Add(r, new HashSet<int>());
                for (int c = 0; c < 9; c++)
                {
                    var key = (r / 3) * 3 + c / 3;
                    if (!sub3Set.ContainsKey(key))
                        sub3Set.Add(key, new HashSet<int>());

                    if (!colSet.ContainsKey(c))
                        colSet.Add(c, new HashSet<int>());

                    if (int.TryParse(board[r][c].ToString(), out int n))
                    {
                        if (rowSet.TryGetValue(r, out var row) && row.Contains(n)
                            || colSet.TryGetValue(c, out var col) && col.Contains(n)
                            || sub3Set.TryGetValue(key, out var sub) && sub.Contains(n))
                            return false;

                        rowSet[r].Add(n);
                        colSet[c].Add(n);
                        sub3Set[key].Add(n);
                    }
                }
            }
            return true;
        }
    }
}
