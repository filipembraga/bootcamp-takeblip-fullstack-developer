import {useState} from 'react';
import Button from '../Button';
import styles from './style.css';

const Card =() =>{

    const [value, setValue] = useState(0);

    function addInCounter(){
        setValue(value + 1)
    }

    function removeInCounter(){
        setValue(value - 1)
    }

    return(
        <div class="card">
            <div class="card-header">
                Meu primeiro Card!
            </div>
            <div class="card-body">
                <Button
                    className="btn btn-success"
                    onClick={addInCounter} 
                >
                    Adicionar
                </Button>
                <Button
                    className="btn btn-danger"
                    onClick={removeInCounter}    
                >
                    Remover
                </Button>
                <p>{value}</p>
            </div>
        </div>
    );
}
export default Card;