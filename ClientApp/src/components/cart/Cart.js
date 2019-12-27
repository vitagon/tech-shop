import React from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faMinus, faPlus } from '@fortawesome/free-solid-svg-icons';
import styles from './Cart.module.css';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import {
  deleteItemFromCart, decrementItemQuantity,
  setItemQuantity, incrementItemQuantity, setRawItemQuantity
} from '../../actions/cartActions';


class Cart extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      quantity: 1
    }
  }

  render() {
    let total = this.props.cartItems.reduce(function(totalAccum, item) {
      return totalAccum + (item.product.price * item.quantity);
    }, 0);
    return (
      <div className={styles.cart}>
        <div id="breadcrumb" class="section">
          <div class="container">
            <div class="row">
              <div class="col-md-12">
                <h3 class="breadcrumb-header">Shopping cart</h3>
                <ul class="breadcrumb-tree">
                  <li><a href="#">Home</a></li>
                  <li class="active">Cart</li>
                </ul>
              </div>
            </div>
          </div>
        </div>

        <div className="section">
          <div class="container">
            <div class="row">
              <div class="col-md-12">
                <div className="cart-items">
                  <ul className={styles['cart-list']}>
                    {this.props.cartItems.map((item, i) => {
                      return (
                        <li className={styles['cart-item']}>

                          <div className={styles['cart-item__main']}>
                            <div className={styles['cart-item-image']}>
                              <img src={item.product.img} />
                            </div>

                            <div className={styles['cart-item-info']}>
                              <div className={styles['cart-item-name']}>
                                <div className={styles['cart-item-title']}>Name</div>
                                <div className={styles['cart-item-value']}>{item.product.name}</div>
                              </div>

                              <div className={styles['cart-item-quantity']}>
                                <div className={styles['cart-item-title']}>Quantity</div>
                                <div className={styles['cart-item-value']}>
                                  <div className={styles['quantity-buttons']}>
                                    <button
                                      className={styles['quantity-button-minus']}
                                      onClick={() => this.props.decrementItemQuantity(item)}
                                    >
                                      <FontAwesomeIcon icon={faMinus} />
                                    </button>
                                    <input
                                      className={styles['quantity-input']}
                                      value={item.quantity}
                                      onChange={(e) => this.props.setRawItemQuantity(item, e.target.value)}
                                      onBlur={(e) => this.props.setItemQuantity(item, e.target.value)}
                                    />
                                    <button
                                      className={styles['quantity-button-plus']}
                                      onClick={() => this.props.incrementItemQuantity(item)}
                                    >
                                      <FontAwesomeIcon icon={faPlus} />
                                    </button>
                                  </div>
                                </div>
                              </div>

                              <div className={styles['cart-item-price']}>
                                <div className={styles['cart-item-title']}>Price</div>
                                <div className={styles['cart-item-value']}>${item.product.price}</div>
                              </div>

                              <div className={styles['cart-item-total']}>
                                <div className={styles['cart-item-title']}>Total</div>
                                <div className={styles['cart-item-value']}>${item.product.price * item.quantity}</div>
                              </div>
                            </div>
                          </div>

                          <div className={styles['cart-item__footer']}>
                            <div className={styles['cart-item-btns']}>
                              <button type="button">Add to wishlist</button>
                              <button type="button" onClick={() => this.props.deleteItemFromCart(item)}>Remove</button>
                            </div>
                          </div>
                        </li>
                      )
                    })}
                  </ul>
                </div>

                <div className={styles['order-total']}>
                  <div className={styles['order-total-content']}>
                    <div className={styles['order-total-title']}>Order Total:</div>
                    <div className={styles['order-total-amount']}>${total}</div>
                  </div>
                </div>

                <div className={styles['cart-buttons']}>
                  <button type="button" className={styles['cart-button-clear']}>Clear cart</button>
                  <button type="button" className={styles['cart-button-checkout']}>Proceed to checkout</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

const mapStateToProps = (state, ownProps) => ({
  cartItems: state.cartReducer.cartItems
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  deleteItemFromCart: deleteItemFromCart,
  setRawItemQuantity: setRawItemQuantity,
  setItemQuantity: setItemQuantity,
  decrementItemQuantity: decrementItemQuantity,
  incrementItemQuantity: incrementItemQuantity
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(Cart);