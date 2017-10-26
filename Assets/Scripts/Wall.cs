﻿using UnityEngine;

public class Wall : MonoBehaviour
{

	public Sprite dmgSprite;
	public int hp = 4;

	public AudioClip[] chopSounds;

	private SpriteRenderer spriteRenderer;

	void Awake()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	public void DamageWall(int loss)
	{
		SoundManager.Instance.RandomizeSfx(chopSounds);
		spriteRenderer.sprite = dmgSprite;
		hp -= loss;
		if (hp <= 0) gameObject.SetActive(false);
	}

}