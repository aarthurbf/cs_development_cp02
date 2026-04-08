# Questão 3 - Modificadores de Acesso

### 1. `public`

Membros declarados como public podem ser acessados de qualquer lugar do código.

**Quando usar:**
- Métodos que fazem parte da interface pública da classe
- Para propriedades que devem ser acessíveis externamente
- Quando você quer que outras pessoas usem esse membro

---
### 2. `private` 

Membros declarados como private só podem ser acessados dentro da própria classe onde foram declarados.

**Quando usar:**
- Para proteger dados
- Para campos que devem ser acessados apenas através de propriedades

---

### 3. `protected`

Membros declarados como protected podem ser acessados dentro da própria classe e também em classes derivadas, mas não são acessíveis de outras classes.

**Quando usar:**
- Para membros que devem ser compartilhados com classes filhas
- Em hierarquias de herança