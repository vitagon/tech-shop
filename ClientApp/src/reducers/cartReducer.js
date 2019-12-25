export const ADD_ITEM_TO_CART = 'ADD_ITEM_TO_CART';
export const DELETE_ITEM_FROM_CART = 'DELETE_ITEM_FROM_CART';

function getCartItemsFromLocalStorage() {
  let cartItems = localStorage.getItem('cart-items');
  if (cartItems && cartItems !== '') {

    try {
      return JSON.parse(cartItems);
    } catch (e) {
      console.error(e);
      return [];
    }
  }
  return [];
}

const initialState = {
  cartItems: getCartItemsFromLocalStorage()
}

function cartReducer(state = initialState, action) {
  switch (action.type) {
    case ADD_ITEM_TO_CART: {
      let cartItem = {
        product: action.data,
        quantity: 1
      }
      let items = [
        ...state.cartItems,
        cartItem
      ];
      localStorage.setItem('cart-items', JSON.stringify(items));
      return Object.assign({}, state, { cartItems: items });
      break;
    }
    case DELETE_ITEM_FROM_CART: {
      let itemIndex = state.cartItems.findIndex(x => x.product.id == action.data);
      let items = [
        ...state.cartItems.slice(0, itemIndex),
        ...state.cartItems.slice(itemIndex + 1)
      ];
      localStorage.setItem('cart-items', JSON.stringify(items));
      return Object.assign({}, state, { cartItems: items });
      break;
    }
    default: {
      return state;
    }
  }
}

export default cartReducer;