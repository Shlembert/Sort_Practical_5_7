using System.Linq;
using UnityEngine;

public class SumOfEvenNumbersInRange : MonoBehaviour
{
    /// <summary>
    /// ����� ��������� ������� OnClick ������ "����� ������ ����� ��������� ���������"
    /// </summary>
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        var want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � ��������� �� {min} �� {max} ������������: {got} - {message}");
    }

    /// <summary>
    /// ����� ��������� ����� ������ ����� � ���������� ��������� 
    /// </summary>
    /// <param name="min">����������� �������� ���������</param>
    /// <param name="max">������������ �������� ���������</param>
    /// <returns>����� ����� ������ �����</returns>
    private int SumEvenNumbersInRange(int min, int max)
    {
        // ���������� ������� ������ ����� ��������� ���� �
        // ������� ������ 0 ���������� ��������� 
        return 0;
    }
}


