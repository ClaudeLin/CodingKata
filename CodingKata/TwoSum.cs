namespace CodingKata
{
    public class TwoSum
    {
        private int _inputNumsIndex;
        private int[] _inputNums;
        private bool _alreadyFoundAns;
        private int[] _twoSumAns;
        private int _targetNum;
        private int _remainNum;

        public int[] GetTwoSumAns(int[] inputNums, int targetNum)
        {
            InitData(inputNums, targetNum);
            while (!_alreadyFoundAns)
            {
                UpdateRemainNum();
                SearchTwoSumAns();
            }

            return _twoSumAns;
        }

        private void InitData(int[] inputNums, int targetNum)
        {
            _remainNum = targetNum;
            _targetNum = targetNum;
            _inputNums = inputNums;
            _inputNumsIndex = -1;
            _twoSumAns = new int[2];
            _alreadyFoundAns = false;
        }

        private void UpdateRemainNum()
        {
            _inputNumsIndex++;
            _remainNum = _targetNum - _inputNums[_inputNumsIndex];
           
        }

        private void SearchTwoSumAns()
        {
            for (var i = _inputNumsIndex + 1; i < _inputNums.Length; i++)
            {
                if (_remainNum == _inputNums[i])
                {
                    _twoSumAns = new[] {_inputNumsIndex, i};
                    _alreadyFoundAns = true;
                    break;
                }
            }
        }
    }
}
