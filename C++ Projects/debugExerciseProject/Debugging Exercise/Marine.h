#pragma once
#include "Entity.h"
class Marine : public Entity
{
public:
	Marine();

	int attack() override;
	int squadSize();
	void takeDamage(int damage) override;

	~Marine();
};

