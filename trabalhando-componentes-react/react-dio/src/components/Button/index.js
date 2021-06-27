import styles from './style.css';

const Button = ({children, className, onClick}) =>{
    return (
        <button 
            type="button" 
            className={className}
            onClick={onClick}
        >
            {children}
        </button>
    )
}
export default Button;