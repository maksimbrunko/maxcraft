using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour {

	public Transform bedrock_block;
	public Transform stone_block;
	public Transform modern_block;
	public Transform ruby_block;

	// use ths for initialization
	void Start () {

		for (int xPos = -5; xPos < 50; xPos += 1) {
			for (int zPos = -5; zPos < 50; zPos+=1) {
				Instantiate (modern_block, new Vector3 (xPos, 0, zPos), modern_block .rotation);
				Instantiate (bedrock_block , new Vector3 (xPos, -3, zPos), bedrock_block.rotation);
				Instantiate (stone_block  , new Vector3 (xPos, -1, zPos), stone_block.rotation);
				Instantiate (ruby_block   , new Vector3 (xPos, -2, zPos), ruby_block.rotation);


			}
			for (int zPos = -1; zPos < 50; zPos++) {
				int yPos = (int)Random.Range(0f, 15f);
				yPos = 1;
				Instantiate (stone_block, new Vector3 (xPos, yPos, zPos), stone_block.rotation);
			}
			for (int zPos = -3; zPos < 50; zPos++) {
				int yPos = (int)Random.Range(0f, 15f);
				yPos = 2;
				Instantiate (modern_block, new Vector3 (xPos, 1, zPos), modern_block.rotation);
			}
			for (int zPos = -2; zPos < 50; zPos++) {
				int yPos = (int)Random.Range(0f, 15f);
				yPos = 3;
				Instantiate (modern_block, new Vector3 (xPos, 2, zPos), modern_block.rotation);
			}
		}
	}
	// Update is called once per frame
	void update () {
	}
}