#pragma once
#include "Entity.h"

class Zergling : public Entity
{
public:
	Zergling();
	Zergling(int zHP, int atk);
	~Zergling();
	void takeDamage(int damage) override;
	int iAttack() override;
};

