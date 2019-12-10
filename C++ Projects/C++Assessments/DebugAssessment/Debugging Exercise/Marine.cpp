#include "Marine.h"
#include "Entity.h"


Marine::Marine()
{
	maxHealth = 50;
	health = maxHealth;
	attack = 20;
}

int Marine::iAttack()
{
	return attack;
}
Marine::Marine(int mHP, int atk) {
	maxHealth = mHP;
	health = maxHealth;
	attack = atk;
}
void Marine::takeDamage(int damage)
{
	health -= damage;
	if (health < 0) {
		health = 0;
	}
}


Marine::~Marine()
{
}
