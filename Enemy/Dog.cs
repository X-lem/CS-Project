using System;

public class Dog : Enemy {

  private static readonly Object[] _DROPS = { new Coin(Coin.Wealth.Default), new Potion(), new Arrow() };
  private static readonly int[] _DROPS_WEIGHT = { 68, 25 , 7 };
  private Item _drop;


  public Dog() {
    var usesIndex = Helpers.RandomResultWeighted(_DROPS_WEIGHT);
    _drop = (Item)_DROPS[usesIndex];

    _maxHealth = _health = 150;
    _damage = 25;
  }

  public override void TakeDamage(double damage) {
    _health -= damage;

    if (_health <= 0) {
      // drop _DROP and delete object.
    }
  }
}