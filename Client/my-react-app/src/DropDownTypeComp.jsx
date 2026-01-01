function DropdownComp() {



    return (

        <div class ="dropdown-container">

  

  <select name ="card-type-dropdown"  id ="card-type-dropdown" multiple>
      <option value="artifact" id="artifact">Artifact</option>
      <option value="instant" id = "instant">Instant</option>
      <option value="sorcery" id="sorcery">Sorcery</option>
      <option value="enchantment" id="enchantment">Enchantment</option>
      <option value="land" id="land">Land</option>
      <option value="planeswalker" id="planeswalker">PlanesWalker</option>
      <option value="battle" id ="battle">Battle</option>


  </select>

  </div>
    )
}

export default DropdownComp;