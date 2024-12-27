using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBlock : MonoBehaviour{

	public GameObject theBlock;
	public int xPos;
	public int zPos;
	public int BlockCount;

	void Start () {
		StartCoroutine(BlockDrop());
	}

	IEnumerator BlockDrop()
	{
		while (BlockCount < 25)
		{
			xPos = Random.Range(9, 0);
			zPos = Random.Range(1, 9);
			Instantiate(theBlock, new Vector3(xPos, 0, zPos), Quaternion.identity);
			yield return new WaitForSeconds(0.1f);
			BlockCount +=1;
		}

	}


}
