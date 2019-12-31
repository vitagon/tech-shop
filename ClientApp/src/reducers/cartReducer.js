export const ADD_ITEM_TO_CART = 'ADD_ITEM_TO_CART';
export const DELETE_ITEM_FROM_CART = 'DELETE_ITEM_FROM_CART';
export const SET_RAW_ITEM_QUANTITY = 'SET_RAW_ITEM_QUANTITY';
export const SET_ITEM_QUANTITY = 'SET_ITEM_QUANTITY';
export const DECREMENT_ITEM_QUANTITY = 'DECREMENT_ITEM_QUANTITY';
export const INCREMENT_ITEM_QUANTITY = 'INCREMENT_ITEM_QUANTITY';
export const COUNT_ITEMS = 'COUNT_ITEMS';
export const COUNT_ITEMS_TOTAL = 'COUNT_ITEMS_TOTAL';

const getCartItemsFromLocalStorage = () => {
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

const countItems = (cartItems) => {
  return cartItems.length;
}

const countTotal = (cartItems) => {
  return cartItems.reduce(function (totalAccum, item) {
    return totalAccum + (item.product.price * item.quantity);
  }, 0);
}

const initialState = {
  cartItems: getCartItemsFromLocalStorage(),
  itemsQuantity: countItems(getCartItemsFromLocalStorage()),
  itemsTotal: countTotal(getCartItemsFromLocalStorage())
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
      return Object.assign({}, state, { cartItems: items, itemsQuantity: ++(state.itemsQuantity) });
      break;
    }
    case DELETE_ITEM_FROM_CART: {
      let itemIndex = state.cartItems.findIndex(x => x.product.id == action.data);
      let items = [
        ...state.cartItems.slice(0, itemIndex),
        ...state.cartItems.slice(itemIndex + 1)
      ];
      localStorage.setItem('cart-items', JSON.stringify(items));
      return Object.assign({}, state, { cartItems: items, itemsQuantity: --(state.itemsQuantity) });
      break;
    }
    case INCREMENT_ITEM_QUANTITY: {
      let itemIndex = state.cartItems.findIndex(x => x.product.id == action.data);
      let item = state.cartItems[itemIndex];
      item.quantity = Number(item.quantity) + 1;
      let items = [
        ...state.cartItems.slice(0, itemIndex),
        item,
        ...state.cartItems.slice(itemIndex + 1)
      ];
      localStorage.setItem('cart-items', JSON.stringify(items));
      return Object.assign({}, state, { cartItems: items });
      break;
    }
    case DECREMENT_ITEM_QUANTITY: {
      let itemIndex = state.cartItems.findIndex(x => x.product.id == action.data);
      let item = state.cartItems[itemIndex];
      if (Number(item.quantity) - 1 <= 0) {
        return state;
      }
      item.quantity = Number(item.quantity) - 1;
      let items = [
        ...state.cartItems.slice(0, itemIndex),
        item,
        ...state.cartItems.slice(itemIndex + 1)
      ];
      localStorage.setItem('cart-items', JSON.stringify(items));
      return Object.assign({}, state, { cartItems: items });
      break;
    }
    case SET_RAW_ITEM_QUANTITY: {
      let id = action.data.id;
      let qty = action.data.qty;
      let itemIndex = state.cartItems.findIndex(x => x.product.id == id);
      let item = state.cartItems[itemIndex];
      item.quantity = qty.trim();
      if (!/^\d+$/.test(qty) && qty !== "") {
        return state;
      }
      let items = [
        ...state.cartItems.slice(0, itemIndex),
        item,
        ...state.cartItems.slice(itemIndex + 1)
      ];
      return Object.assign({}, state, { cartItems: items });
      break;
    }
    case SET_ITEM_QUANTITY: {
      let id = action.data.id;
      let qty = action.data.qty;
      let itemIndex = state.cartItems.findIndex(x => x.product.id == id);
      let item = state.cartItems[itemIndex];
      
      
      if (qty.trim() === "") {
        item.quantity = 1;
      } else {
        item.quantity = qty.trim();
      }
      
      let items = [
        ...state.cartItems.slice(0, itemIndex),
        item,
        ...state.cartItems.slice(itemIndex + 1)
      ];

      localStorage.setItem('cart-items', JSON.stringify(items));
      return Object.assign({}, state, { cartItems: items });
      break;
    }
    case COUNT_ITEMS: {
      return Object.assign({}, state, { itemsQuantity: state.cartItems.length });
      break;
    }
    case COUNT_ITEMS_TOTAL: {
      return Object.assign({}, state, { itemsTotal: countTotal(state.cartItems) });
      break;
    }
    default: {
      return state;
    }
  }
}

export default cartReducer;