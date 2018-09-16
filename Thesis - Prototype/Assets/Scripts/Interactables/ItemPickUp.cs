﻿using UnityEngine;

public class ItemPickUp : Interactable {

	public Item item;	// Item to put in the inventory if picked up

	// When the player interacts with the item
	public override void Interact()
	{
		base.Interact();
		
		PickUp();
	}

	// Pick up the item
	public void PickUp ()
	{
		Debug.Log("Picked up " + item.name);
		Inventory.instance.Add(item);	// Add to inventory

		Destroy(gameObject);	// Destroy item from scene
	}

}