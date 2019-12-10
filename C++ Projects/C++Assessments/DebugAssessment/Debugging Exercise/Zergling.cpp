#include "Zergling.h"



Zergling::Zergling()
{
	maxHealth = 20;
	health = maxHealth;
	attack = 10;
}

Zergling::Zergling(int zHP, int atk) {
	maxHealth = zHP;
	health = maxHealth;
	attack = atk;
}

int Zergling::iAttack()
{
	return attack;
}

void Zergling::takeDamage(int damage)
{
	health -= damage;
	if (health < 0)
		health = 0;
}

Zergling::~Zergling()
{
}
