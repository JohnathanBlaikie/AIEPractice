#pragma once
#include "Entity.h"

class Zergling : public Entity
{
public:
	Zergling();

	int attack();
	int squadSize();
	void takeDamage(int damage);

	~Zergling();
};

