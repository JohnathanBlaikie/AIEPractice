#include "Marine.h"



Marine::Marine()
{
	health = 50;
}

int Marine::attack()
{
	return 10;
}

void Marine::takeDamage(int damage)
{
	health -= damage;
}


Marine::~Marine()
{
}
