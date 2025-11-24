# ULTIMATE-CODEQUEST-DLC

## **General Description**
This project is an expansion (DLC) of the game **CodeQuest**, a C# console game that simulates the experience of a wizard apprentice who must complete various magical trials. The player progresses through 7 different chapters, each with unique mechanics.

---

## **Game Sections**

### **🎮 Main Menu**
- Central navigation system with 7 main options
- Error control and input validation
- Data persistence between chapters

### **🧙 Chapter 1: Wizard Training**
**Initial training** of the wizard with a progress system based on accumulated power points.
**Objective**: Develop the character's magical power
- **Character creation**: Name introduction (validated)
- **Meditation system**: 5 days of random training
- **Power calculation**: Accumulation of power points
- **Power rankings**:
  - ≤20: "Zyn the Buggy" - Must repeat
  - <30: "Raoden the Elantrian" - Beginner
  - <35: "Arka Nullpointer" - Intermediate
  - <40: "Elarion of the Embers" - Expert
  - ≥40: "ITB-Wizard the Gray" - Master

### **⚔️ Chapter 2: Combat and Level System**
**Combat system** with random monsters using dice, with progressive leveling.
**Objective**: Level up by fighting monsters
- **Random monsters**: 8 types with different health points
- **Dice system**: Combat with 6-sided dice
- **ASCII representation**: Visual dice in console
- **Level system**: From 1 to 5 (maximum)

### **⛏️ Chapter 3: Gold Mining**
**Strategic mining** on a map with hidden resources and limited attempts.
**Objective**: Accumulate "bits" (game currency)
- **Mining map**: 5x5 matrix with hidden resources
- **Probability system**: 60% chance to find gold
- **Attempt limit**: 5 attempts per session
- **Cell tracking**: Prevents repeating positions

### **🎒 Chapter 4: Inventory**
**Basic management** of inventory with display of acquired items.
**Objective**: Manage acquired items
- **Dynamic array**: Expandable based on purchases
- **Visualization**: List of owned items
- **Empty state**: Message when no items

### **🏪 Chapter 5: Shop**
**Economic system** with shop and item purchases using game currency.
**Objective**: Buy items with bits
- **Item catalog**: 5 items with prices
- **Funds validation**: Control of sufficient bits
- **Purchase system**: Adds items to inventory
- **Visual table**: Table format for the shop

### **🔮 Chapter 6: Spells by Level**
**Displays spells** available according to the level achieved by the player in chapter 6.
**Objective**: Show available spells based on level
- **Jagged array**: Irregular structure for levels
- **Visual emojis**: Graphical representation of spells
- **Gradual progress**: More spells at higher levels

### **📜 Chapter 7: Ancient Spells Decryption**
**Decryption puzzle** of texts with multiple methods and completion system.
**Objective**: Decrypt scrolls with magical methods
- **Three decryption methods**:
  1. 🗑️ Remove spaces (dark magic)
  2. 🔢 Count vowels (count runes)
  3. ⚡ Extract numbers (extract mana)
- **Completion system**: 3 scrolls to decrypt
- **Extensive validation**: Error control and inputs

# ULTIMATE-CODEQUEST-DLC: JOC DE PROVES

## **CHAPTER ONE:**

**Normal Case: name \-\> “albaricoque”** 

| instructions | iterations | variables |  |  |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | firstName | name  | rand | actualPow | totalPow | hours | i | \- |
| 1 | \- | albaricoque | \- | {System.Random} | 0 | 0 |  | \- | \- |
| 2 | \- | albaricoque | Albaricoque | \- | \- | \- |  | \- | (String.IsNullOrWhiteSpace(name) OR name.Length \> 15\) \-\> FALSE |
| 3 | \- | \- | \- | {System.Random} | 0 | 0 | {System. Random} | 1 | i \<= 5 \-\> TRUE |
| 3 | 1 | \- | \- | {System.Random} | 0 | 0 | {System. Random} | 1 | i \<= 5 \-\> TRUE |
| 3 | 1 | \- | \- | 7 | 7 | 7 | 2 | 1 |  i \<= 5 \-\> TRUE |
| 3 | 2 | \- | \- | {System.Random} | 7 | 7 | {System. Random} | 2 | i \<= 5 \-\> TRUE |
| 3 | 2 | \- | \- | 5 | 5 | 12 | 6 | 2 | i \<= 5 \-\> TRUE |
| 3 | 3 | \- | \- | {System.Random} | 5 | 12 | {System. Random} | 3 | i \<= 5 \-\> TRUE |
| 3 | 3 | \- | \- | 9 | 9 | 21 | 12 | 3 | i \<= 5 \-\> TRUE |
| 3 | 4 | \- | \- | {System.Random} | 9 | 21 | {System. Random} | 4 | i \<= 5 \-\> TRUE |
| 3 | 4 | \- | \- | 4 | 4 | 25 | 1 | 4 | i \<= 5 \-\> TRUE |
| 3 | 5 | \- | \- | {System.Random} | 9 | 25 | {System. Random} | 5 | i \<= 5 \-\> TRUE |
| 3 | 5 | \- | \- | 7 | 7 | 32 | 22 | 5 | i \<= 5 \-\> TRUE |
| 3 | 6 | \- | \- | 7 | 7 | 32 | 22 | 6 | i \<= 5 \-\> FALSE |
| 4 | \- | \- | \- | \- | \- | 32 | \- | \- | totalPow \<= 20 \-\> FALSE |
| 4 | \- | \- | \- | \- | \- | 32 | \- | \- | totalPow \< 30 \-\> FALSE |
| 4 | \- | \- | Albaricoque |  | \- | 32 | \- | \- | totalPow \< 35 \-\> TRUE |

OUTPUT: 

- **Albaricoque, from now on you are Arka Nullpointer.**  
- **You are a magic breeze invoker.**

**Error Case 1: name \-\> “”** 

- The user inserts a null input

| instructions | iterations | variables |  |  |  |  |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | firstName | name  | rand | actualPow | totalPow | currentLvl | numLevel | hours | i | \- |
| 1 | \- |  | \- | {System.Random} | 0 | 0 | Normal Human |  |  | \- | \- |
| 2 | \- |  |  | \- | \- | \- |  |  |  | \- | (String.IsNullOrWhiteSpace(name) OR name.Length \> 15\) \-\> TRUE |

OUTPUT: 

- **Invalid name, please input a name with at least one character and shorter than 15 characters.**

**Error Case 2: name \-\> “AsjabadUltimatePro”**

- The user inserts an string larger than 15 characters.

| instructions | iterations | variables |  |  |  |  |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | firstName | name  | rand | actualPow | totalPow | currentLvl | numLevel | hours | i | \- |
| 1 | \- | AsjabadUltimatePro | \- | {System.Random} | 0 | 0 | Normal Human | \- | {System.Random} | \- | \- |
| 2 | \- | \- | AsjabadUltimatePro | \- | \- | \- | \- | \- | \- | \- | (String.IsNullOrWhiteSpace(name) OR name.Length \> 15\) \-\> TRUE |

OUTPUT: 

- **Invalid name, please input a name with at least one character and shorter than 15 characters.**

## **CHAPTER TWO:**

**Normal case: input \-\> “”**

- The user inserts 9 times a null character and then 0\.

| Instruction | Iteration | variables |  |  |  |  |  |  | Condition |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
|  |  | monsterList\[aux2, 0\] | aux2 | life (Initial) | input | roll | life | level |  |
| 1 | 1 | Ancient Dragon | 7 | 50 | \- | \- | monsterList\[aux2, 1\] |  | \- |
| 1 | 1 | \- | \- | 50 | (ENTER) | \- | 50 |  | input \== "0" \-\> FALSE |
| 2 | 1 | \- | \- | 50 | \- | 6 (Simulated) | 44 |  | life \> 0  \-\> FALSE |
| 2 | 2 | \- | \- | 44 | (ENTER) | 6 (Simulated) | 38 |  | life \> 0 \-\> FALSE |
| 2 | 3 | \- | \- | 38 | (ENTER) | 6 (Simulated) | 32 |  | life \> 0 \-\> FALSE |
| 2 | 4 | \- | \- | 32 | (ENTER) | 6 (Simulated) | 26 |  | life \> 0 \-\> FALSE |
| 2 | 5 | \- | \- | 26 | (ENTER) | 6 (Simulated) | 20 |  | life \> 0 \-\> FALSE |
| 2 | 6 | \- | \- | 20 | (ENTER) | 6 (Simulated) | 14 |  | life \> 0 \-\> FALSE |
| 2 | 7 | \- | \- | 14 | (ENTER) | 6 (Simulated) | 8 |  | life \> 0 \-\> FALSE |
| 2 | 8 | \- | \- | 8 | (ENTER) | 6 (Simulated) | 2 |  | life \> 0 \-\> FALSE |
| 2 | 9 | \- | \- | 2 | (ENTER) | 6 (Simulated) | \-4  |  | life \> 0 \-\> TRUE |
| 3 | \- | \- | \- | 0 | \- | \- | 0 | 1 | level \< 5 \-\> TRUE |
| 1 | 2 | Forest Goblin | 1 | 5 | \- | \- | monsterList\[aux2, 1\] |  |  |
| 1 | 2 | \- | \- | 5 | 0 | \- | 5 |  | input \== "0" \-\> TRUE |

OUTPUT: 

- **Welcome to the dark forest, lets start grinding some monsters to gain level\!**  
    
- **A wild Ancient Dragon appeared, it has 50 points of life. Lets fight\!**  
* **... 9 rounds of rolling (simulated roll 6 each time) ...**  
* **Final Roll (Roll 6): You rolled 6, Ancient Dragon's total life: 0\.**  
* **Level Up: LEVEL UP\! Your level is now 1\.**


- **A wild Forest goblin appeared, it has 5 points of life. Lets fight\!**  
* **Exit: Nice session\! Goodbye\!**

## **CHAPTER THREE:**

**1: Normal case:** 

- Initial State: totalBits \= 0, validCords \= false. Simulated coinMap: Assume coinMap\[2, 1\] \= 1 (Gold), coinMap\[4, 4\] \= 1 (Gold), others 0\. Simulated rand.Next(5, 50): Roll 1: 30; Roll 2: 15\.

| Instruction | Iteration | variables |  |  |  |  |  |  |  |  |  |  |  | Condition |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| \- | \- | i | validCords (Before While) | Input X | Input Y | x (Abs) | y (Abs) | isXInt | isYInt | validCords (After Check) | coinMap\[y, x\] | bits | totalBits | \- |
| 1 | 1 | 4 | FALSE | 1 | 2 | 1 | 2 | TRUE | TRUE | TRUE | 1 (Gold) | 30 | 30 | validCords \== false \-\> FALSE |
| switch | 1 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 1 | \- | \- | coinMap\[y, x\] \== 1 |
| 1 | 2 | 3 | FALSE | 3 | 3 | 3 | 3 | TRUE | TRUE | TRUE | 0 (Miss) | \- | 30 | validCords \== false \-\> FALSE |
| switch | 2 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 0 | \- | \- | coinMap\[y, x\] \== default |
| 1 | 3 | 2 | FALSE | 4 | 4 | 4 | 4 | TRUE | TRUE | TRUE | 1 (Gold) | 15 | 45 | validCords \== false \-\> FALSE |
| switch | 3 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 1 | \- | \- | coinMap\[y, x\] \== 1 |
| 1 | 4 | 1 | FALSE | 1 | 2 | 1 | 2 | TRUE | TRUE | TRUE | 2 (Checked) | \- | 45 | validCords \== false \-\> FALSE |
| switch | 4 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 2 | \- | \- | coinMap\[y, x\] \== 2 |
| 1 | 5 | 0 | FALSE | 5 | 5 | 5 | 5 | TRUE | TRUE | TRUE | 0 (Miss) | \- | 45 | validCords \== false \-\> FALSE |
| switch | 5 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 0 | \- | \- | coinMap\[y, x\] \== default |

OUTPUT: 

- **End of the session, your final bit score: 45**

**2: Limit Case (Boundary Coordinates and Already Checked):**

- Initial State: totalBits \= 0, validCords \= false. Simulated coinMap: Assume coinMap\[5, 5\] \= 1 (Gold), coinMap\[1, 1\] \= 0 (Miss), others 0\. Simulated rand.Next(5, 50): Roll 1: 40\.

| Instruction | Iteration | variables |  |  |  |  |  |  |  |  |  |  |  | Condition |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| \- | \- | i | validCords (Before While) | Input X | Input Y | x (Abs) | y (Abs) | isXInt | isYInt | validCords (After Check) | coinMap\[y, x\] | bits | totalBits | Condition |
|  1 | 1 | 4 | FALSE | 5 | 5 | 5 | 5 | TRUE | TRUE | TRUE | 1 | 40 | 40 | validCords \== false \-\> FALSE |
| switch | 1 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 1 | \- | \- | coinMap\[y, x\] \== 1 |
| 1 | 2 | 3 | FALSE | 1 | 1 | 1 | 1 | TRUE | TRUE | TRUE | 0 | \- | 40 | validCords \== false \-\> FALSE |
| switch | 2 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 0 | \- | \- | coinMap\[y, x\] \== default |
| 1 | 3 | 2 | FALSE | 5 | 5 | 5 | 5 | TRUE | TRUE | TRUE | 2  | \- | 40 | validCords \== false \-\> FALSE |
| switch | 3 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 2 | \- | \- | coinMap\[y, x\] \== 2 |
| 1 | 4 | 1 | FALSE | \-1 | \-5 | 1 | 5 | TRUE | TRUE | TRUE | 0 | \- | 40 | validCords \== false \-\> FALSE |
| switch | 4 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 0 | \- | \- | coinMap\[y, x\] \== default |
| 1 | 5 | 0 | FALSE | 1 | 5 | 1 | 5 | TRUE | TRUE | TRUE | 0 | \- | 40 | validCords \== false \-\> FALSE |
| switch | 5 | \- | \- | \- | \- | \- | \- | \- | \- | \- | 0 | \- | \- | coinMap\[y, x\] \== default |

OUTPUT: 

- **End of the session, your final bit score: 40**

**3: Error case**

- Input X \= “A”, Input Y \= S

| Instruction | Iteration | variables |  |  |  |  |  |  |  |  |  |  |  | Condition |
| ----- | ----- | ----- | ----- | :---- | ----- | ----- | ----- | ----- | ----- | ----- | :---- | :---- | ----- | ----- |
|  |  | i | validCords (Before While) | Input X | Input Y | x (Abs) | y (Abs) | isXInt | isYInt | validCords (After Check) | coinMap\[y, x\] | bits | totalBits | Condition |
| 1 | 1 | 4 | FALSE | A | 1 | 0 | 1 | FALSE | TRUE | FALSE | \- | \- | 0 | validCords \== false  |
| 2 | 1 | 4 | FALSE | 2 | S | 1 | 1 | TRUE | FALSE | FALSE | \- | \- | 0 | validCords \== false |

OUTPUT: 

- **Invalid coordinates, try again**  
- **Invalid coordinates, try again**

## **CHAPTER FIVE:**

**1: Normal case:**

- Initial State: totalBits \= 75, inventory \= {"Wooden Sword", "Helmet"}.

| Instruction | Iteration | variables |  |  |  |  |  |  | Condition |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| \- | \- | Input | validId (TryParse) | buyId | shop\[buyId, 1\] (Cost) | totalBits (Before) | insuf (Cost \> Bits) | totalBits (After) |  |
| 1 | 1 | 2 | TRUE | 2 | 10 | 75 | FALSE | 65 | \!validId || buyId \> 5 \-\> FALSE; buyId \== 0 \-\> FALSE |
| 2 | \- | \- | \- | \- | \- | \- | FALSE | \- | insuf \-\> FALSE |
| 3 | 2 | 4 | TRUE | 4 | 40 | 65 | FALSE | 25 | \!validId || buyId \> 5 \-\> FALSE; buyId \== 0 \-\> FALSE |
| 4 | \- | \- | \- | \- | \- | \- | FALSE | \- | insuf \-\> FALSE |
| 5 | 3 | 0 | TRUE | 0 | \- | 25 | \- | 25 | \!validId || buyId \> 5 \-\> FALSE; buyId \== 0 \-\> TRUE |
| do | 4 | \- | \- | \- | \- | \- | \- | \- | buyId \!= 0 \-\> FALSE |

OUTPUT: 

- You bought a Healing Potion for 10 bits\! Total bits: 65   
- You bought a Crossbow for 40 bits\! Total bits: 25   
- See you next time\!   
  (Final Inventory State: {"Wooden Sword", "Helmet", "Healing Potion", "Crossbow"})

**2: Limit case (Insufficient Funds and Boundary Purchase):**

- Initial State: totalBits \= 25, inventory \= {}

| Instruction | Iteration | variables |  |  |  |  |  |  | Condition |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
|  |  | Input | validId (TryParse) | buyId | shop\[buyId, 1\] (Cost) | totalBits (Before) | insuf (Cost \> Bits) | totalBits (After) |  |
| 1 | 1 | 1 | TRUE | 1 | 30 | 25 | TRUE | 25 | \!validId || buyId \> 5 \-\> FALSE; buyId \== 0 \-\> FALSE |
| 2 | \- | \- | \- | \- | \- | \- | TRUE | \- | insuf \-\> TRUE |
| 3 | 2 | 5 | TRUE | 5 | 20 | 25 | FALSE | 5 | \!validId || buyId \> 5 \-\> FALSE; buyId \== 0 \-\> FALSE |
| 4 | \- | \- | \- | \- | \- | \- | FALSE | \- | insuf \-\> FALSE |
| 5 | 3 | 0 | TRUE | 0 | \- | 5 | \- | 5 | \!validId || buyId \> 5 \-\> FALSE; buyId \== 0 \-\> TRUE |
| do | 4 | \- | \- | \- | \- | \- | \- | \- | buyId \!= 0 \-\> FALSE |

OUTPUT: 

- You bought a Healing Potion for 10 bits\! Total bits: 65   
- You bought a Crossbow for 40 bits\! Total bits: 25   
- See you next time\!   
  (Final Inventory State: {"Wooden Sword", "Helmet", "Healing Potion", "Crossbow"})


**2: Error case (Invalid Input and ID Out of Bounds):**

| Instruction | Iteration | variables |  |  |  |  |  |  | Condition |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
|  |  | Input | validId (TryParse) | buyId | shop\[buyId, 1\] (Cost) | totalBits (Before) | insuf (Cost \> Bits) | totalBits (After) |  |
| 1 | 1 | 1 | TRUE | 1 | 30 | 25 | TRUE | 25 | \!validId || buyId \> 5 \-\> FALSE; buyId \== 0 \-\> FALSE |
| 2 | \- | \- | \- | \- | \- | \- | TRUE | \- | insuf \-\> TRUE |
| 3 | 2 | 5 | TRUE | 5 | 20 | 25 | FALSE | 5 | \!validId || buyId \> 5 \-\> FALSE; buyId \== 0 \-\> FALSE |

OUTPUT: 

- Invalid item, try again  
- Invalid item, try again

## **CHAPTER SEVEN:**

**1: Normal Case:**

- Initial State: quit \= false, completed \= 0, vowels \= 0, methodNum \= 0\. Scroll to check: scrolls\[1\]

| Instruction | Iteration | variables |  |  |  |  |  | Condition |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
|  |  | Input | validMethod | methodNum | i (Bucle For Char) | vowels (i.e. 'a', 'e', 'i', 'o', 'u') | completed |  |
| 1 | 1 | 2 | TRUE | 2 | \- | \- | 0 | \!validMethod \-\> FALSE |
| 2 | \- | \- | \- | 2 | \- | \- | \- | methodNum \== 1 |
| 3 | \- | \- | \- | 2 | 1...78 (Recorre el Scroll 2\) | \- | \- | methodNum \== 2 |
| foreach | 3.1 | \- | \- | 2 | Caràcter 1 ('A') | 1 | \- | VowelsList.Contains(i) |
| 3.2 | \- | \- | \- | 2 | Caràcter 2 ('l') | 1 | \- | VowelsList.Contains(i) \-\> FALSE |
| 3.3 | \- | \- | \- | 2 | ... | ... | \- | ... |
| 3.4 | \- | \- | \- | 2 | Final de la cadena | 26 | \- | VowelsList.Contains(i) |
| 4 | \- | \- | \- | \- | \- | 26 | 1 | \- |
| 5 | 2 | 0 | TRUE | 0 | \- | 26 | 1 | \!validMethod \-\> FALSE |
| 6 | \- | \- | \- | 0 | \- | \- | \- | methodNum \== 1/2/3/default |
| do | 3 | \- | \- | 0 | \- | \- | \- | quit \-\> FALSE, completed \== MAXCOMPLETE \-\> FALSE, methodNum \!= 0 \-\> FALSE |

OUTPUT: 

- Alright, you decoded the scroll\! Let's see how it looks like:   
- This scroll has 22 arcane runes on it   
- Good job, see you later\!

**2: Error case (Invalid Input)**

- Initial State: quit \= false, completed \= 0, methodNum \= 0\.

| Instruction  | Iteration | variables |  |  |  |  | Condition |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
|  |  | Input | validMethod | methodNum | vowels | completed |  |
| 1 | 1 | H | FALSE | 0 | \- | 0 | \!validMethod \-\> TRUE |
| 1.1 | 1.1 | H | \- | \- | \- | \- | \!validMethod |
| 2 | 2 | 5 | TRUE | 5 | \- | 0 | \!validMethod \-\> FALSE |
| 3 | \- | \- | \- | 5 | \- | \- | \- |
| 4 | \- | \- | \- | 5 | \- | \- | 0 |
| 5 | 3 | 1 | TRUE | 1 | \- | \- | 0 |
| 6 | \- | \- | \- | 1 | \- | \- | \- |
| 7 | \- | \- | \- | 1 | \- | \- | 1 |
| 8 | 4 | 0 | TRUE | 0 | \- | \- | 1 |
| do | 5 | \- | \- | 0 | \- | \- | \- |

OUTPUT: 

- Invalid script, try again  
- Invalid script, try again   
- Alright, you decoded the scroll\! Let's see how it looks like:   
- Themagicdragonwhichshalldefestheheroesrestsonhiscave   
- Good job, see you later\!
