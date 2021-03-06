using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager
{
	/// <summary>
	/// Creates an item form the inputs
	/// </summary>
	/// <param name="name"></param>
	/// <param name="level"></param>
	/// <param name="value"></param>
	/// <param name="rarity"></param>
	/// <param name="itemPrefabName"></param>
	/// <returns>returns the item</returns>
	public static Item CreateItem(string name, int level, int value, ItemRarity rarity, string itemPrefabName)
	{
		ItemPrefab itemPrefab = Resources.Load<ItemPrefab>("Items/" + itemPrefabName);
		Item item = new Item
		{
			name = name,
			level = level,
			value = value,
			rarity = rarity,
			model = itemPrefab.model,
			sprite = itemPrefab.sprite,
			itemPrefabName = itemPrefabName,
		};
		return item;
	}

	/// <summary>
	/// Creates a weapon from the inputs
	/// </summary>
	/// <param name="name"></param>
	/// <param name="level"></param>
	/// <param name="value"></param>
	/// <param name="rarity"></param>
	/// <param name="itemPrefabName"></param>
	/// <param name="damage"></param>
	/// <param name="enchantment"></param>
	/// <returns>returns the weapon</returns>
	public static Weapon CreateWeapon(string name, int level, int value, ItemRarity rarity, string itemPrefabName, float damage, Enchantment enchantment)
	{
		WeaponPrefab weaponPrefab = Resources.Load<WeaponPrefab>("Items/Weapons/" + itemPrefabName);
		Weapon weapon = new Weapon
		{
			name = name,
			level = level,
			value = value,
			rarity = rarity,
			itemPrefabName = itemPrefabName,
			model = weaponPrefab.model,
			sprite = weaponPrefab.sprite,
			damage = damage,
			enchantment = enchantment,
			type = weaponPrefab.weaponType,
			isDualWielded = weaponPrefab.isDualWelded
		};
		return weapon;
	}

	/// <summary>
	/// Creates a armor from the inputs
	/// </summary>
	/// <param name="name"></param>
	/// <param name="level"></param>
	/// <param name="value"></param>
	/// <param name="rarity"></param>
	/// <param name="itemPrefabName"></param>
	/// <param name="defence"></param>
	/// <param name="enchantment"></param>
	/// <returns>returns the armor</returns>
	public static Armor CreateArmor(string name, int level, int value, ItemRarity rarity, string itemPrefabName, float defence, Enchantment enchantment)
	{
		ArmorPrefab armorPrefab = Resources.Load<ArmorPrefab>("Items/Armor/" + itemPrefabName);
		Armor armor = new Armor
		{
			name = name,
			level = level,
			value = value,
			rarity = rarity,
			itemPrefabName = itemPrefabName,
			sprite = armorPrefab.sprite,
			model = armorPrefab.model,
			defence = defence,
			enchantment = enchantment,
			type = armorPrefab.type
		};
		return armor;
	}
	
	/// <summary>
	/// Gets the color for a specific Rarity
	/// </summary>
	/// <param name="itemRarity">the rarity</param>
	/// <returns>returns color for rarity</returns>
	public static Color GetRarityColor(ItemRarity itemRarity)
	{
		switch (itemRarity)
		{
			case ItemRarity.Trash:
				return Color.white;
			case ItemRarity.Normal:
				return Color.green;
			case ItemRarity.Rare:
				return Color.blue;
			case ItemRarity.Epic:
				return Color.magenta;
			case ItemRarity.Legendary:
				return Color.yellow;
			case ItemRarity.Dev:
				return Color.cyan;
			default:
				return Color.red;
		}
	}
	public static GameObject GetRarityBox(ItemRarity itemRarity)
	{
		switch (itemRarity)
		{
			case ItemRarity.Trash:
				return Resources.Load<GameObject>("LootBoxes/Trash Box");
			case ItemRarity.Normal:
				return Resources.Load<GameObject>("LootBoxes/Common Box");
			case ItemRarity.Rare:
				return Resources.Load<GameObject>("LootBoxes/Rare Box");
			case ItemRarity.Epic:
				return Resources.Load<GameObject>("LootBoxes/Epic Box");
			case ItemRarity.Legendary:
				return Resources.Load<GameObject>("LootBoxes/Legendary Box");
			case ItemRarity.Dev:
				return Resources.Load<GameObject>("LootBoxes/Legendary Box");
			default:
				return Resources.Load<GameObject>("LootBoxes/Trash Box");
		}
	}
}
