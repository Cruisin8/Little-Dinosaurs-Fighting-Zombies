using UnityEngine;

public class MissileCreator : MonoBehaviour
{
	[SerializeField] private GameObject missilePrefab;
	[SerializeField] private Transform playerTransform;

	// ����ħ���ɵ�
	public void CreateMissile()
	{
		Instantiate(missilePrefab, playerTransform.position, Quaternion.identity);
	}
}
