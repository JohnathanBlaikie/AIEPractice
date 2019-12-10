#pragma once
#include "Entity.h"
class Marine : public Entity
{
public:
	Marine();

	int attack();
	int squadSize();
	void takeDamage(int damage);

	~Marine();
};

