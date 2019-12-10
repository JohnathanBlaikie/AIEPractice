#include "Zergling.h"



Zergling::Zergling()
{
	maxHealth = 20;
	health = maxHealth;
}

Zergling::Zergling(int zHP, int atk) {
	maxHealth = zHP;
	health = maxHealth;
	attack = atk;
}

int Zergling::attack()
{
	return atk;
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
