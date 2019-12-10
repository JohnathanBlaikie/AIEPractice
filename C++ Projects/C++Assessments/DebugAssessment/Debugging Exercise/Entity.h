#pragma once
class Entity
{
public:
	Entity();
	~Entity();

	virtual int iAttack();
	virtual void takeDamage(int damage);
	bool isAlive();

	int health;
	int maxHealth;
	int attack;
private:
};

