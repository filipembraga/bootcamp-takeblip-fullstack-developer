import Item from './components/Item'
import Card from './components/Card'

const App = () => {
  return (
    <>
      <h1>Minha primeira aplicação com React</h1>
      <ul>
        <Item text='Item 1'/>
        <Item text='Item 2'/>
        <Item text='Item 3'/>
      </ul>
      <Card/>
    </>
  );
}
export default App;