#include "Entity.h"



Entity::Entity()
{
}

bool Entity::isAlive()
{
	return health != 0;
}

Entity::~Entity()
{
}

int Entity::iAttack()
{
	return 0;
}

void Entity::takeDamage(int damage)
{
}

