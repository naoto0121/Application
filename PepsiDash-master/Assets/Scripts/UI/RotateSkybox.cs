﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UserInterface{
	
	public class RotateSkybox : MonoBehaviour
	{
		//　回転スピード
		[SerializeField]
		private float rotateSpeed = 10f;
		//　スカイボックスのマテリアル
		private Material skyboxMaterial;

		// Use this for initialization
		void Start()
		{
			//　Lighting Settingsで指定したスカイボックスのマテリアルを取得
			skyboxMaterial = RenderSettings.skybox;
		}

		// Update is called once per frame
		void Update()
		{
			//　スカイボックスマテリアルのRotationを操作して角度を変化させる
			skyboxMaterial.SetFloat("_Rotation", Mathf.Repeat(skyboxMaterial.GetFloat("_Rotation") + rotateSpeed * Time.deltaTime, 360f));
		}
	}
}